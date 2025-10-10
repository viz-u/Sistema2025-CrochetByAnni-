using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema2025
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // 1) ToolStrip siempre acoplada a la izquierda
            toolStrip1.Dock = DockStyle.Left;

            // 2) Panel contenedor para la zona de trabajo
            panelHost.Dock = DockStyle.Fill;

            // 3) Margen interior alrededor del contenido
            panelHost.Padding = new Padding(20);

            // 4) Tu panel principal de usuarios ocupa todo el espacio dentro del host
            plUsuarios.Dock = DockStyle.Fill;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.txtPasswordForm.Text = "";
            this.cboxTipoUsuario.Text = "";
            this.txtUsuarioForm.Text = "";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

