using System;
using System.Windows.Forms;
using DAO;
using DominioCrochet;

namespace Sistema2025
{
    public partial class frmUsuarios : Form
    {
        private readonly UsuarioDAO _dao = new UsuarioDAO();
        private int _usuarioIdSel = 0; // 0 = ninguno

        // Toggle helpers
        private bool _rowWasSelectedOnMouseDown = false;
        private int _rowIndexMouseDown = -1;
        private bool _shouldToggleDeselectOnMouseUp = false;

        public frmUsuarios()
        {
            InitializeComponent();

            // --- Suscripciones seguras (evita duplicados) ---
            dgvUsuarios.SelectionChanged -= dgvUsuarios_SelectionChanged;
            dgvUsuarios.CellMouseDown -= dgvUsuarios_CellMouseDown;
            dgvUsuarios.MouseUp -= dgvUsuarios_MouseUp;
            dgvUsuarios.MouseDown -= dgvUsuarios_MouseDown;

            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            dgvUsuarios.CellMouseDown += dgvUsuarios_CellMouseDown;
            dgvUsuarios.MouseUp += dgvUsuarios_MouseUp;
            dgvUsuarios.MouseDown += dgvUsuarios_MouseDown;

            tsbtnNuevo.Click -= tsbtnNuevo_Click;
            tsbtnGuardar.Click -= tsbtnGuardar_Click;
            tsbtnActualizar.Click -= tsbtnActualizar_Click;
            tsbtnEliminar.Click -= tsbtnEliminar_Click;
            tsbtnSalir.Click -= tsbtnCerrar_Click;

            tsbtnNuevo.Click += tsbtnNuevo_Click;
            tsbtnGuardar.Click += tsbtnGuardar_Click;
            tsbtnActualizar.Click += tsbtnActualizar_Click;
            tsbtnEliminar.Click += tsbtnEliminar_Click;
            tsbtnSalir.Click += tsbtnCerrar_Click;

            this.Load -= frmUsuarios_Load;
            this.Load += frmUsuarios_Load;
        }

        // ================== LOAD ==================
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // Layout (como tenías)
            toolStrip1.Dock = DockStyle.Left;
            panelHost.Dock = DockStyle.Fill;
            panelHost.Padding = new Padding(20);
            plUsuarios.Dock = DockStyle.Fill;

            // Combo roles
            cboxTipoUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxTipoUsuario.Items.Clear();
            cboxTipoUsuario.Items.AddRange(new object[] { "SuperAdmin", "Admin", "Empleado" });
            cboxTipoUsuario.SelectedIndex = 2; // Empleado

            // Grid
            ConfigurarGrid();

            // Carga inicial
            CargarUsuarios();
            LimpiarFormulario();
        }

        // ================ GRID =================
        private void ConfigurarGrid()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Columns.Clear();

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "ID", DataPropertyName = "UsuarioId", Width = 60 });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Nombre", DataPropertyName = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Usuario", DataPropertyName = "UsuarioNombre", Width = 160 });

            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Rol", DataPropertyName = "Rol", Width = 120 });

            dgvUsuarios.Columns.Add(new DataGridViewCheckBoxColumn
            { HeaderText = "Activo", DataPropertyName = "Activo", Width = 70 });

            // Sin selección inicial
            dgvUsuarios.ClearSelection();
            dgvUsuarios.CurrentCell = null;
        }

        private void CargarUsuarios()
        {
            try
            {
                dgvUsuarios.DataSource = _dao.ListarUsuarios();
                dgvUsuarios.ClearSelection();
                dgvUsuarios.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios:\n" + ex.Message,
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Llenar formulario al cambiar selección
        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow?.DataBoundItem is Usuario u)
            {
                _usuarioIdSel = (int)u.UsuarioId;
                txtNombre.Text = u.Nombre;
                txtUsuarioForm.Text = u.UsuarioNombre;
                txtPasswordForm.Clear(); // nunca mostramos contraseñas
                int idx = cboxTipoUsuario.Items.IndexOf(u.Rol ?? "Empleado");
                cboxTipoUsuario.SelectedIndex = idx >= 0 ? idx : 2;
            }
        }

        // Captura estado antes del click
        private void dgvUsuarios_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _rowWasSelectedOnMouseDown = false;
            _rowIndexMouseDown = -1;
            _shouldToggleDeselectOnMouseUp = false;

            if (e.RowIndex >= 0)
            {
                _rowIndexMouseDown = e.RowIndex;
                _rowWasSelectedOnMouseDown = dgvUsuarios.Rows[e.RowIndex].Selected;

                // Si ya estaba seleccionada y es click izquierdo, marcamos toggle
                if (_rowWasSelectedOnMouseDown && e.Button == MouseButtons.Left)
                {
                    _shouldToggleDeselectOnMouseUp = true;
                }
            }
        }

        // Aplica el toggle después de que el DataGridView hizo su selección normal
        private void dgvUsuarios_MouseUp(object sender, MouseEventArgs e)
        {
            // Toggle deselect si corresponde
            if (_shouldToggleDeselectOnMouseUp &&
                _rowIndexMouseDown >= 0 &&
                e.Button == MouseButtons.Left)
            {
                dgvUsuarios.ClearSelection();
                dgvUsuarios.CurrentCell = null;
                _usuarioIdSel = 0;
                LimpiarFormulario();
                _shouldToggleDeselectOnMouseUp = false;
                return;
            }
        }

        // Clic en espacio vacío => deseleccionar
        private void dgvUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            var ht = dgvUsuarios.HitTest(e.X, e.Y);
            if (ht.Type == DataGridViewHitTestType.None)
            {
                dgvUsuarios.ClearSelection();
                dgvUsuarios.CurrentCell = null;
                _usuarioIdSel = 0;
                LimpiarFormulario();
            }
        }

        // ================ BOTONES =================
        private void tsbtnNuevo_Click(object sender, EventArgs e) => LimpiarFormulario();

        private void tsbtnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarObligatorios()) return;

            tsbtnGuardar.Enabled = false; // anti doble clic
            try
            {
                var u = new Usuario
                {
                    Nombre = txtNombre.Text.Trim(),
                    UsuarioNombre = txtUsuarioForm.Text.Trim(),
                    Rol = cboxTipoUsuario.SelectedItem?.ToString() ?? "Empleado",
                    Activo = true,
                    ContrasenaHash = UsuarioDAO.HashSha256(txtPasswordForm.Text) // SHA-256 (Unicode)
                };

                int nuevoId = _dao.InsertarUsuario(u);
                MessageBox.Show($"Usuario guardado. ID={nuevoId}", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarUsuarios();
                SeleccionarFilaPorId(nuevoId);
                txtPasswordForm.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message,
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tsbtnGuardar.Enabled = true;
            }
        }

        private void tsbtnActualizar_Click(object sender, EventArgs e)
        {
            if (_usuarioIdSel <= 0)
            {
                MessageBox.Show("Selecciona un usuario de la lista.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidarObligatorios(sinPassword: true)) return;

            tsbtnActualizar.Enabled = false;
            try
            {
                var u = new Usuario
                {
                    UsuarioId = _usuarioIdSel,
                    Nombre = txtNombre.Text.Trim(),
                    UsuarioNombre = txtUsuarioForm.Text.Trim(),
                    Rol = cboxTipoUsuario.SelectedItem?.ToString() ?? "Empleado",
                    Activo = true
                };

                // si hay nueva contraseña, cambiar; si no, conservar hash actual
                if (!string.IsNullOrWhiteSpace(txtPasswordForm.Text))
                    u.ContrasenaHash = UsuarioDAO.HashSha256(txtPasswordForm.Text);
                else
                    u.ContrasenaHash = _dao.BuscarUsuarioPorId(_usuarioIdSel)?.ContrasenaHash;

                bool ok = _dao.ActualizarUsuario(u);
                if (!ok) throw new Exception("No se actualizó ninguna fila.");

                MessageBox.Show("Usuario actualizado.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarUsuarios();
                SeleccionarFilaPorId(_usuarioIdSel);
                txtPasswordForm.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar:\n" + ex.Message,
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tsbtnActualizar.Enabled = true;
            }
        }

        private void tsbtnEliminar_Click(object sender, EventArgs e)
        {
            if (_usuarioIdSel <= 0)
            {
                MessageBox.Show("Selecciona un usuario de la lista.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var r = MessageBox.Show("¿Eliminar este usuario?\nID: " + _usuarioIdSel,
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            tsbtnEliminar.Enabled = false;
            try
            {
                // Borrado lógico (Activo = 0). Para físico, pasa true.
                bool ok = _dao.EliminarUsuario(_usuarioIdSel, borradoDuro: false);
                if (!ok) throw new Exception("No se eliminó ninguna fila.");

                MessageBox.Show("Usuario eliminado.", "Usuarios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarUsuarios();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message,
                    "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tsbtnEliminar.Enabled = true;
            }
        }

        private void tsbtnCerrar_Click(object sender, EventArgs e) => this.Close();

        // ================ HELPERS =================
        private bool ValidarObligatorios(bool sinPassword = false)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            { MessageBox.Show("Nombre es obligatorio."); txtNombre.Focus(); return false; }

            if (string.IsNullOrWhiteSpace(txtUsuarioForm.Text))
            { MessageBox.Show("Usuario es obligatorio."); txtUsuarioForm.Focus(); return false; }

            if (!sinPassword && string.IsNullOrWhiteSpace(txtPasswordForm.Text))
            { MessageBox.Show("Contraseña es obligatoria."); txtPasswordForm.Focus(); return false; }

            if (cboxTipoUsuario.SelectedIndex < 0)
            { MessageBox.Show("Selecciona un tipo de usuario."); cboxTipoUsuario.DroppedDown = true; return false; }

            return true;
        }

        private void LimpiarFormulario()
        {
            _usuarioIdSel = 0;
            txtNombre.Clear();
            txtUsuarioForm.Clear();
            txtPasswordForm.Clear();
            cboxTipoUsuario.SelectedIndex = 2; // Empleado
            // no tocar selección aquí; la manejamos en eventos
            txtNombre.Focus();
        }

        private void SeleccionarFilaPorId(int usuarioId)
        {
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                if (row.DataBoundItem is Usuario u && u.UsuarioId == usuarioId)
                {
                    row.Selected = true;
                    dgvUsuarios.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }
    }
}
