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
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            // 1) ToolStrip pegada a la izquierda
            toolStrip1.Dock = DockStyle.Left;

            // 2) Panel contenedor que ocupa el resto del formulario
            panelHost.Dock = DockStyle.Fill;

            // Márgenes internos alrededor del área de trabajo
            panelHost.Padding = new Padding(20);

            // 3) Tu panel principal de Inventario ocupa todo el host
            plInventario.Dock = DockStyle.Fill;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.txtNombreInv.Text = "";
            this.txtPrecioInv.Text = "";
            this.cboxTipoInv.SelectedIndex = -1;
        }

        private void txtPrecioInv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

