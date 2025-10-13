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
            //hola
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
           
        }


        private void txtPrecioInv_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxTipoInv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panelHost_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

