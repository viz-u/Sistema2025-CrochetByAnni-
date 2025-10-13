using System;
using System.Windows.Forms;
using DAO;
using DominioCrochet;
using Sistema2025.Utils;   // <-- usa tu clase de sesión real

namespace Sistema2025
{
    public partial class frmLogin : Form
    {
        private readonly UsuarioDAO _usuarioDao = new UsuarioDAO();

        public frmLogin()
        {
            InitializeComponent();

            // El botón en tu Designer se llama "button1"
            this.AcceptButton = btnAcceder;   // <-- no btnAcceder
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            textBox1.Focus();

            // Enter en password = click al botón
            txtPassword.KeyDown += (s, ev) => { if (ev.KeyCode == Keys.Enter) btnAcceder.PerformClick(); };
        }

        // Asegúrate que el Designer tenga: button1.Click += button1_Click;
        private void Acceder(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Escribe tu usuario.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Escribe tu contraseña.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                var u = _usuarioDao.Login(usuario, password);   // <- debe devolver null si falla
                if (u == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                // Si Activo es bool? en tu dominio, normalízalo
                bool activo = (u.Activo is bool b) ? b : true;
                if (!activo)
                {
                    MessageBox.Show("El usuario está inactivo.", "Acceso denegado",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar sesión
                SesionActual.UsuarioId = u.UsuarioId ?? 0;               // si es int. Si fuera int?: u.UsuarioId ?? 0;
                SesionActual.Nombre = u.Nombre ?? "";
                SesionActual.Usuario = u.UsuarioNombre ?? "";
                SesionActual.Rol = u.Rol ?? "";
                SesionActual.Activo = activo;

                // Abrir principal
                this.Hide();
                using (var principal = new frmPrincipal())
                {
                    principal.ShowDialog();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar credenciales:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
