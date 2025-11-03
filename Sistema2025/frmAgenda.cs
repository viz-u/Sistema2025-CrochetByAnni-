using DAOmysql;
using DominioCrochet;
using Sistema2025.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Sistema2025
{
    public partial class frmAgenda : Form
    {
        private readonly AgendaDAO _dao = new AgendaDAO();

        // id seleccionado (null = nada seleccionado)
        private int? _selectedId = null;

        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            // Layout
            toolStrip1.Dock = DockStyle.Left;
            panelHost.Dock = DockStyle.Fill;
            panelHost.Padding = new Padding(20);
            plAgenda.Dock = DockStyle.Fill;

            // Config DataGrid
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            // Eventos para selección/deselección suave
            dataGridView1.DataBindingComplete += (s, ev) => dataGridView1.ClearSelection();
            dataGridView1.CellClick += dgv_CellClickToggleSelect;
            dataGridView1.CellDoubleClick += dgv_CellDoubleClickFill;

            // Cargar datos
            CargarGrid();
            LimpiarForm();
        }

        // ============== UI helpers ==============

        private void CargarGrid()
        {
            try
            {
                var lista = _dao.ObtenerAgendas(); // sin filtros, todas
                dataGridView1.DataSource = lista;
                OcultarColumnasNoAmigables();
                dataGridView1.ClearSelection();
                _selectedId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar agenda:\n" + ex.Message, "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OcultarColumnasNoAmigables()
        {
            // Muestra lo útil y esconde lo técnico
            TryHide("UsuarioId");
            TryHide("CreadoEn");
        }
        private void TryHide(string colName)
        {
            if (dataGridView1.Columns[colName] != null)
                dataGridView1.Columns[colName].Visible = false;
        }

        private void LimpiarForm()
        {
            txtTitulo.Clear();
            txtDesc.Clear();
            dateFecha.Value = DateTime.Today;
            _selectedId = null;
            dataGridView1.ClearSelection();
        }

        private Agenda LeerForm()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                throw new Exception("El título es obligatorio.");

            return new Agenda
            {
                AgendaId = _selectedId ?? 0,
                Titulo = txtTitulo.Text.Trim(),
                Descripcion = string.IsNullOrWhiteSpace(txtDesc.Text) ? null : txtDesc.Text.Trim(),
                Fecha = dateFecha.Value.Date,
                // Si tu login cargó SesionActual, úsalo; si no, guarda null
                UsuarioId = SesionActual.UsuarioId > 0 ? SesionActual.UsuarioId : (int?)null
            };
        }

        private void LlenarFormDesdeFila(DataGridViewRow row)
        {
            if (row?.DataBoundItem is not Agenda a) return;

            _selectedId = a.AgendaId;
            txtTitulo.Text = a.Titulo ?? "";
            txtDesc.Text = a.Descripcion ?? "";
            dateFecha.Value = a.Fecha == default ? DateTime.Today : a.Fecha;
        }

        // ============== DataGrid selección/deselección ==============

        private void dgv_CellClickToggleSelect(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // encabezado
            var row = dataGridView1.Rows[e.RowIndex];

            // si ya estaba seleccionada -> deselecciona
            if (row.Selected)
            {
                dataGridView1.ClearSelection();
                _selectedId = null;
                return;
            }

            // selecciona y carga al formulario
            dataGridView1.ClearSelection();
            row.Selected = true;
            LlenarFormDesdeFila(row);
        }

        private void dgv_CellDoubleClickFill(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            LlenarFormDesdeFila(row);
        }

        // ============== ToolStrip botones ==============

        private void toolStripButton1_Click(object sender, EventArgs e) // Nuevo
        {
            LimpiarForm();
            txtTitulo.Focus();
        }

        private void tsbtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var ag = LeerForm();
                if (_selectedId != null && _selectedId > 0)
                {
                    // Si hay id seleccionado, pregunta si actualizar o realmente crear nuevo
                    var r = MessageBox.Show("Hay un registro seleccionado. ¿Deseas crear uno nuevo?",
                        "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.No)
                    {
                        // entonces actualiza el seleccionado
                        _dao.ActualizarAgenda(ag);
                        MessageBox.Show("Agenda actualizada.", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        return;
                    }
                }

                // Insertar nuevo
                int nuevoId = _dao.InsertarAgenda(ag);
                MessageBox.Show($"Agenda guardada. ID = {nuevoId}", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar:\n" + ex.Message, "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbtnActualizar_Click(object sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Selecciona una fila para actualizar.", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var ag = LeerForm();
                ag.AgendaId = _selectedId.Value;
                _dao.ActualizarAgenda(ag);
                MessageBox.Show("Agenda actualizada.", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar:\n" + ex.Message, "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (_selectedId == null)
            {
                MessageBox.Show("Selecciona una fila para eliminar.", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ask = MessageBox.Show("¿Seguro que deseas eliminar este registro?", "Agenda",
                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask != DialogResult.Yes) return;

            try
            {
                _dao.EliminarAgenda(_selectedId.Value);
                MessageBox.Show("Agenda eliminada.", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid();
                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar:\n" + ex.Message, "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e) // Cerrar
        {
            Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { /* sin uso */ }

        private void panelHost_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
