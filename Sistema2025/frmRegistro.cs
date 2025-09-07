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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            // 1) ToolStrip siempre pegada a la izquierda
            toolStrip1.Dock = DockStyle.Left;

            // 2) Panel contenedor que ocupa el resto de la ventana
            panelHost.Dock = DockStyle.Fill;

            // 3) Margen alrededor del área de trabajo
            panelHost.Padding = new Padding(20);

            // 4) Tu panel de registro ocupa todo el espacio del host
            plRegistro.Dock = DockStyle.Fill;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void plRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.cboxAccionRegistro.SelectedIndex = -1;
            this.cboxMateriaRegistro.SelectedIndex = -1;
            this.cboxProductoRegistro.SelectedIndex = -1;
            this.numCantidad.Value = 0;
            this.dateFechaRegistro.Value = DateTime.Now;

        }
    }
}

