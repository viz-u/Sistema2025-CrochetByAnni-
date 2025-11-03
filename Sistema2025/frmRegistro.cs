using DAO;                 // DAOs
using DAOmysql;
using DominioCrochet;      // Entidades
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sistema2025
{
    public partial class frmRegistro : Form
    {
        // ========= DAOs =========
        private readonly ProductoDAO _productoDAO = new ProductoDAO();
        private readonly MateriaPrimaDAO _mpDAO = new MateriaPrimaDAO();
        private readonly VentaDAO _ventaDAO = new VentaDAO();
        private readonly DetalleVentaDAO _dvDAO = new DetalleVentaDAO();
        private readonly MovimientoDAO _movDAO = new MovimientoDAO();
        private readonly DetalleMovimientoDAO _dmovDAO = new DetalleMovimientoDAO();

        // ========= Estado UI =========
        private Producto? _productoSel;
        private MateriaPrima? _mpSel;

        public frmRegistro()
        {
            InitializeComponent();

            // Toolstrip
            toolStripButton1.Click += toolStripButton1_Click; // Nuevo
            toolStripButton2.Click += toolStripButton2_Click; // Guardar
            toolStripButton3.Click += toolStripButton3_Click; // Actualizar (no usado)
            toolStripButton4.Click += toolStripButton4_Click; // Eliminar (no usado)
            toolStripButton5.Click += toolStripButton5_Click; // Cerrar

            // “BUSCAR”: refresca según acción
            btnRegistrar.Click += btnRegistrar_Click;

            // Selección en grids
            dataGridView1.SelectionChanged += dgvProductos_SelectionChanged;
            dataGridView2.SelectionChanged += dgvMaterias_SelectionChanged;
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            // Layout de tu plantilla
            toolStrip1.Dock = DockStyle.Left;
            panelHost.Dock = DockStyle.Fill;
            panelHost.Padding = new Padding(20);
            plRegistro.Dock = DockStyle.Fill;

            // Valores default
            numCantidad.DecimalPlaces = 2;
            numCantidad.Maximum = 1000000;
            dateFechaRegistro.Value = DateTime.Now;

            // Combos
            if (cboxAccionRegistro.Items.Count == 0)
                cboxAccionRegistro.Items.AddRange(new object[] { "Venta", "Movimiento" });

            if (cboxMateriaRegistro.Items.Count == 0)
                cboxMateriaRegistro.Items.AddRange(new object[] { "Ingreso", "Egreso" });

            // Cargar listas
            CargarListas();
            CargarHistorial();
        }

        // ============ Nuevo ============
        private void toolStripButton1_Click(object sender, EventArgs e) => Limpiar();

        private void Limpiar()
        {
            cboxAccionRegistro.SelectedIndex = -1;
            cboxMateriaRegistro.SelectedIndex = -1;
            numCantidad.Value = 0;
            dateFechaRegistro.Value = DateTime.Now;

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.DataSource = null; // Carrito Venta
            dataGridView4.DataSource = null; // Movimientos
            _productoSel = null;
            _mpSel = null;
        }

        // ============ Guardar ============
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (string.Equals(cboxAccionRegistro.Text, "Venta", StringComparison.OrdinalIgnoreCase))
            {
                RegistrarVenta();
                return;
            }

            if (string.Equals(cboxAccionRegistro.Text, "Movimiento", StringComparison.OrdinalIgnoreCase))
            {
                RegistrarMovimiento();
                return;
            }

            MessageBox.Show("Selecciona una Acción (Venta o Movimiento).", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void RegistrarVenta()
        {
            if (_productoSel is null)
            {
                MessageBox.Show("Selecciona un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cantidad = (decimal)numCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1) Venta
                var venta = new Venta
                {
                    Fecha = dateFechaRegistro.Value,
                    UsuarioId = null // si manejas usuario logueado, colócalo aquí
                };
                int ventaId = _ventaDAO.InsertarVenta(venta);

                // 2) Detalle
                var detalle = new DetalleVenta
                {
                    VentaId = ventaId,
                    ProductoId = _productoSel.ProductoId,
                    Cantidad = (int)Math.Round(cantidad), // si tu SP espera int
                    PrecioUnitario = _productoSel.PrecioVenta
                };
                _dvDAO.InsertarDetalle(detalle);

                MessageBox.Show($"Venta registrada (ID {ventaId}).", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Visual: mostrar en grid “Venta”
                var fila = new
                {
                    VentaId = ventaId,
                    Producto = _productoSel.Nombre,
                    Cantidad = detalle.Cantidad,
                    PUnit = detalle.PrecioUnitario,
                    Total = detalle.Cantidad * detalle.PrecioUnitario,
                    Fecha = venta.Fecha
                };
                dataGridView3.DataSource = new List<object> { fila };

                CargarHistorial();
                LimpiarCamposRapidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registrando Venta: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrarMovimiento()
        {
            if (_mpSel is null)
            {
                MessageBox.Show("Selecciona una Materia Prima.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cantidad = (decimal)numCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tipo de movimiento: Entrada/Salida
            var tipoUI = cboxMateriaRegistro.Text?.Trim();
            if (string.IsNullOrEmpty(tipoUI))
            {
                MessageBox.Show("Selecciona si es Ingreso o Egreso.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Convención: E = Entrada, S = Salida
            char tipoMov = string.Equals(tipoUI, "Ingreso", StringComparison.OrdinalIgnoreCase) ? 'E' : 'S';

            try
            {
                // 1) Movimiento
                var mov = new Movimiento
                {
                    Tipo = tipoMov.ToString(),
                    Fecha = dateFechaRegistro.Value,
                    Concepto = $"{(tipoMov == 'E' ? "Entrada" : "Salida")} MP",
                    UsuarioId = null
                };
                int movId = _movDAO.InsertarMovimiento(mov);

                // 2) Detalle
                var det = new DetalleMovimiento
                {
                    MovimientoId = movId,
                    MateriaPrimaId = _mpSel.MateriaPrimaId,
                    Cantidad = (int)Math.Round(cantidad),   // si tu SP usa int
                    CostoUnitario = _mpSel.CostoUnitario
                };
                _dmovDAO.InsertarDetalle(det);

                MessageBox.Show($"Movimiento registrado (ID {movId}).", "OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Visual: mostrar en grid “Movimiento”
                var fila = new
                {
                    MovimientoId = movId,
                    Tipo = tipoMov,
                    MateriaPrima = _mpSel.Nombre,
                    Cantidad = det.Cantidad,
                    CostoUnit = det.CostoUnitario,
                    Importe = det.Cantidad * det.CostoUnitario,
                    Fecha = mov.Fecha
                };
                dataGridView4.DataSource = new List<object> { fila };

                CargarHistorial();
                LimpiarCamposRapidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error registrando Movimiento: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCamposRapidos()
        {
            numCantidad.Value = 0;
            dateFechaRegistro.Value = DateTime.Now;
            // se deja la selección actual para registrar más rápido más líneas si el usuario quiere
        }

        // ============ Actualizar/Eliminar (placeholders) ============
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualizar no está implementado en este formulario.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eliminar no está implementado en este formulario.", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============ Buscar/Refrescar ============
        private void btnRegistrar_Click(object? sender, EventArgs e)
        {
            CargarListas();
            CargarHistorial();
        }

        private void CargarListas()
        {
            try
            {
                // Productos
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = _productoDAO.ObtenerProductos(
                    texto: null, soloActivos: true, page: null, pageSize: null, orden: null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar Productos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                // Materias
                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = _mpDAO.ObtenerMateriasPrimas(
                    texto: null, soloActivos: true, page: null, pageSize: null, orden: null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar Materias Primas: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarHistorial()
        {
            try
            {
                // Saco “algo” de historial de ambos lados para ilustrar
                var ventas = _ventaDAO.ObtenerVentas(
                    desde: DateTime.Now.AddMonths(-1),
                    hasta: DateTime.Now,
                    usuarioId: null, page: 1, pageSize: 50);

                var tabla = new DataTable();
                tabla.Columns.Add("Tipo");
                tabla.Columns.Add("Id");
                tabla.Columns.Add("Fecha", typeof(DateTime));
                tabla.Columns.Add("Detalle");

                foreach (var v in ventas)
                    tabla.Rows.Add("Venta", v.VentaId, v.Fecha, $"Venta #{v.VentaId}");

                // No tenemos un “ListarMovimientos” directo, así que muestro lo que se guardó en esta sesión
                // (Si tienes SP de consulta, cámbialo por _movDAO.Listar(...) ya implementado)
                var ultMovs = _movDAO.Listar(desde: DateTime.Now.AddMonths(-1), hasta: DateTime.Now,
                                             tipo: null, usuarioId: null, page: 1, pageSize: 50);
                foreach (var m in ultMovs)
                    tabla.Rows.Add("Mov", m.MovimientoId, m.Fecha, $"Mov {m.Tipo} #{m.MovimientoId}");

                // Orden por fecha desc
                var view = tabla.DefaultView;
                view.Sort = "Fecha DESC";

                dataGridView5.AutoGenerateColumns = true;
                dataGridView5.DataSource = view.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el Historial: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============ Selección de grids ============
        private void dgvProductos_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Producto p)
                _productoSel = p;
        }

        private void dgvMaterias_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow?.DataBoundItem is MateriaPrima mp)
                _mpSel = mp;
        }

        // ============ Eventos vacíos del diseñador ============
        private void toolStripButton5_Click(object sender, EventArgs e) => Close();
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void plRegistro_Paint(object sender, PaintEventArgs e) { }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cboxMateriaRegistro_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panelHost_Paint(object sender, PaintEventArgs e) { }
    }
}
