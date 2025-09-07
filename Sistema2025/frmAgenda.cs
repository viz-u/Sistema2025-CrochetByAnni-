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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void Recordatorios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.txtTitulo.Text = "";
            this.txtDesc.Text = "";
            this.dateFecha.Text = "";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            // ToolStrip pegada a la izquierda
            toolStrip1.Dock = DockStyle.Left;

            // Panel contenedor para el área de trabajo
            panelHost.Dock = DockStyle.Fill;
            panelHost.Padding = new Padding(20); // margen interno

            // Tu panel de agenda ocupa todo el host
            plAgenda.Dock = DockStyle.Fill;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}


