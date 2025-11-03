using System;
using System.Windows.Forms;
using DAO;
using DAOmysql;                 // ProductoDAO, MateriaPrimaDAO
using DominioCrochet;      // Producto, MateriaPrima

namespace Sistema2025
{
    public partial class frmInventario : Form
    {
        // =======================
        // DAOs
        // =======================
        private readonly ProductoDAO _productoDAO = new ProductoDAO();
        private readonly MateriaPrimaDAO _mpDAO = new MateriaPrimaDAO();

        // =======================
        // Estado seleccionado
        // =======================
        private int? _productoIdSel = null;
        private int? _mpIdSel = null;

        public frmInventario()
        {
            InitializeComponent();

            // Wire-up por si el diseñador no generó los Click
            toolStripButton1.Click += toolStripButton1_Click; // Nuevo
            toolStripButton2.Click += toolStripButton2_Click; // Guardar
            toolStripButton3.Click += toolStripButton3_Click; // Actualizar
            toolStripButton4.Click += toolStripButton4_Click; // Eliminar
            toolStripButton5.Click += toolStripButton5_Click; // Cerrar

            // Grids: seleccionar fila → llenar campos
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged; // Productos
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged; // Materias primas
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            // Layout
            toolStrip1.Dock = DockStyle.Left;
            panelHost.Dock = DockStyle.Fill;
            panelHost.Padding = new Padding(20);
            plInventario.Dock = DockStyle.Fill;

            // Config numéricos
            numericUpDown3.DecimalPlaces = 2; numericUpDown3.Maximum = 100000000;
            numericUpDown1.Maximum = 100000000;

            numericUpDown4.DecimalPlaces = 2; numericUpDown4.Maximum = 100000000;
            numericUpDown2.DecimalPlaces = 2; numericUpDown2.Maximum = 100000000;
            numericUpDown5.DecimalPlaces = 2; numericUpDown5.Maximum = 100000000;

            // Tipo Materia Prima (si quieres catálogo propio, cámbialo)
            if (comboBox1.Items.Count == 0)
                comboBox1.Items.AddRange(new object[] { "Hilo", "Tela", "Accesorio", "Otro" });

            RefrescarGrids();
            ModoNuevo(); // limpia campos y resetea selección
        }

        // =======================
        // Botón: Cerrar
        // =======================
        private void toolStripButton5_Click(object sender, EventArgs e) => Close();

        // =======================
        // Botón: Nuevo (limpiar)
        // =======================
        private void toolStripButton1_Click(object sender, EventArgs e) => ModoNuevo();

        private void ModoNuevo()
        {
            // Producto
            _productoIdSel = null;
            txtNombreInv.Clear();
            numericUpDown3.Value = 0;   // Precio
            textBox1.Clear();           // SKU
            numericUpDown1.Value = 0;   // Cantidad
            dataGridView1.ClearSelection();

            // Materia Prima
            _mpIdSel = null;
            comboBox1.SelectedIndex = -1;
            textBox4.Clear();            // Nombre
            numericUpDown4.Value = 0;    // Costo
            textBox2.Clear();            // Unidad
            numericUpDown2.Value = 0;    // Cantidad
            textBox5.Clear();            // Color
            textBox3.Clear();            // Lote
            numericUpDown5.Value = 0;    // Min Reorden
            dataGridView2.ClearSelection();
        }

        // =======================
        // Botón: Guardar (insertar)
        // =======================
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            bool guardoAlgo = false;

            // ---- Producto (panel izquierdo) ----
            if (!string.IsNullOrWhiteSpace(txtNombreInv.Text) && _productoIdSel is null)
            {
                try
                {
                    var p = new Producto
                    {
                        Nombre = txtNombreInv.Text.Trim(),
                        PrecioVenta = Convert.ToDecimal(numericUpDown3.Value),
                        SKU = string.IsNullOrWhiteSpace(textBox1.Text) ? null : textBox1.Text.Trim(),
                        StockProducto = Convert.ToInt32(numericUpDown1.Value),
                        Activo = true
                    };
                    int id = _productoDAO.InsertarProducto(p);
                    MessageBox.Show($"Producto guardado (ID {id}).", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardoAlgo = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error guardando Producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // ---- Materia Prima (panel derecho) ----
            if (!string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text) && _mpIdSel is null)
            {
                try
                {
                    var mp = new MateriaPrima
                    {
                        Tipo = comboBox1.Text.Trim(),
                        Nombre = textBox4.Text.Trim(),
                        CostoUnitario = Convert.ToDecimal(numericUpDown4.Value),
                        Unidad = string.IsNullOrWhiteSpace(textBox2.Text) ? "pieza" : textBox2.Text.Trim(),
                        StockActual = Convert.ToDecimal(numericUpDown2.Value),
                        Color = string.IsNullOrWhiteSpace(textBox5.Text) ? null : textBox5.Text.Trim(),
                        Lote = string.IsNullOrWhiteSpace(textBox3.Text) ? null : textBox3.Text.Trim(),
                        MinimoReorden = numericUpDown5.Value == 0 ? (decimal?)null : Convert.ToDecimal(numericUpDown5.Value),
                        Activo = true
                    };
                    int id = _mpDAO.InsertarMateriaPrima(mp);
                    MessageBox.Show($"Materia Prima guardada (ID {id}).", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    guardoAlgo = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error guardando Materia Prima: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!guardoAlgo)
            {
                MessageBox.Show("Llena los campos de Producto o Materia Prima para registrar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RefrescarGrids();
            ModoNuevo();
        }

        // =======================
        // Botón: Actualizar
        // =======================
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            bool actualizo = false;

            // Producto seleccionado
            if (_productoIdSel is int pid)
            {
                try
                {
                    var p = new Producto
                    {
                        ProductoId = pid,
                        Nombre = txtNombreInv.Text.Trim(),
                        PrecioVenta = Convert.ToDecimal(numericUpDown3.Value),
                        SKU = string.IsNullOrWhiteSpace(textBox1.Text) ? null : textBox1.Text.Trim(),
                        StockProducto = Convert.ToInt32(numericUpDown1.Value),
                        Activo = true
                    };
                    _productoDAO.ActualizarProducto(p);
                    MessageBox.Show("Producto actualizado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizo = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error actualizando Producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Materia Prima seleccionada
            if (_mpIdSel is int mid)
            {
                try
                {
                    var mp = new MateriaPrima
                    {
                        MateriaPrimaId = mid,
                        Tipo = comboBox1.Text.Trim(),
                        Nombre = textBox4.Text.Trim(),
                        CostoUnitario = Convert.ToDecimal(numericUpDown4.Value),
                        Unidad = string.IsNullOrWhiteSpace(textBox2.Text) ? "pieza" : textBox2.Text.Trim(),
                        StockActual = Convert.ToDecimal(numericUpDown2.Value),
                        Color = string.IsNullOrWhiteSpace(textBox5.Text) ? null : textBox5.Text.Trim(),
                        Lote = string.IsNullOrWhiteSpace(textBox3.Text) ? null : textBox3.Text.Trim(),
                        MinimoReorden = numericUpDown5.Value == 0 ? (decimal?)null : Convert.ToDecimal(numericUpDown5.Value),
                        Activo = true
                    };
                    _mpDAO.InsertarMateriaPrima(mp);
                    MessageBox.Show("Materia Prima actualizada.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizo = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error actualizando Materia Prima: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!actualizo)
            {
                MessageBox.Show("Selecciona un registro en el grid para actualizar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RefrescarGrids();
            ModoNuevo();
        }

        // =======================
        // Botón: Eliminar
        // =======================
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            // Producto
            if (_productoIdSel is int pid)
            {
                if (MessageBox.Show($"¿Eliminar el Producto #{pid}?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        _productoDAO.EliminarProducto(pid, borradoDuro: false);
                        MessageBox.Show("Producto eliminado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarGrids();
                        ModoNuevo();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error eliminando Producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Materia Prima
            if (_mpIdSel is int mid)
            {
                if (MessageBox.Show($"¿Eliminar la Materia Prima #{mid}?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Si tu DAO no tiene este método aún, coméntalo o implementa el SP y el método.
                        _mpDAO.EliminarMateriaPrima(mid, borradoDuro: false);
                        MessageBox.Show("Materia Prima eliminada.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarGrids();
                        ModoNuevo();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error eliminando Materia Prima: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            MessageBox.Show("Selecciona un registro en el grid para eliminar.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // =======================
        // Cargar grids
        // =======================
        private void RefrescarGrids()
        {
            try
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = _productoDAO.ObtenerProductos(
                    texto: null, soloActivos: true, page: null, pageSize: null, orden: null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar Productos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                dataGridView2.AutoGenerateColumns = true;
                dataGridView2.DataSource = _mpDAO.ObtenerMateriasPrimas(
                    texto: null, soloActivos: true, page: null, pageSize: null, orden: null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar Materias Primas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =======================
        // Selección de grids → llena campos
        // =======================
        private void dataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.DataBoundItem == null)
            {
                _productoIdSel = null;
                return;
            }

            var row = dataGridView1.CurrentRow.DataBoundItem;
            // DataBoundItem es un Producto (por el DAO)
            if (row is Producto p)
            {
                _productoIdSel = p.ProductoId;
                txtNombreInv.Text = p.Nombre;
                numericUpDown3.Value = SafeDec(p.PrecioVenta);
                textBox1.Text = p.SKU ?? "";
                numericUpDown1.Value = SafeInt((int)p.StockProducto);
            }
        }

        private void dataGridView2_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null || dataGridView2.CurrentRow.DataBoundItem == null)
            {
                _mpIdSel = null;
                return;
            }

            var row = dataGridView2.CurrentRow.DataBoundItem;
            if (row is MateriaPrima mp)
            {
                _mpIdSel = mp.MateriaPrimaId;
                comboBox1.Text = mp.Tipo;
                textBox4.Text = mp.Nombre;
                numericUpDown4.Value = SafeDec(mp.CostoUnitario);
                textBox2.Text = mp.Unidad;
                numericUpDown2.Value = SafeDec((int)mp.StockActual);
                textBox5.Text = mp.Color ?? "";
                textBox3.Text = mp.Lote ?? "";
                numericUpDown5.Value = SafeDec(mp.MinimoReorden ?? 0m);
            }
        }

        // Helpers para no reventar por límites de NumericUpDown
        private decimal SafeDec(decimal value)
        {
            if (value < numericUpDown3.Minimum) return numericUpDown3.Minimum;
            if (value > numericUpDown3.Maximum) return numericUpDown3.Maximum;
            return value;
        }
        private decimal SafeDec(int value)
        {
            decimal v = value;
            if (v < numericUpDown1.Minimum) return numericUpDown1.Minimum;
            if (v > numericUpDown1.Maximum) return numericUpDown1.Maximum;
            return v;
        }
        private decimal SafeDec(double value) => SafeDec((decimal)value);
        private decimal SafeDec(float value) => SafeDec((decimal)value);
        private decimal SafeDec(long value) => SafeDec((decimal)value);

        private decimal SafeDecNullable(decimal? value) => SafeDec(value ?? 0m);
        private decimal SafeDec(decimal value, NumericUpDown ctrl)
        {
            if (value < ctrl.Minimum) return ctrl.Minimum;
            if (value > ctrl.Maximum) return ctrl.Maximum;
            return value;
        }
        private decimal SafeDecN(decimal? value, NumericUpDown ctrl) => SafeDec(value ?? 0m, ctrl);
        private decimal SafeInt(int value)
        {
            decimal v = value;
            if (v < numericUpDown1.Minimum) return numericUpDown1.Minimum;
            if (v > numericUpDown1.Maximum) return numericUpDown1.Maximum;
            return v;
        }

        // Eventos vacíos generados por el diseñador (si los necesitas)
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void toolStripButton1_DoubleClick(object sender, EventArgs e) { }
        private void txtPrecioInv_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void cboxTipoInv_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void panelHost_Paint(object sender, PaintEventArgs e) { }
    }
}
