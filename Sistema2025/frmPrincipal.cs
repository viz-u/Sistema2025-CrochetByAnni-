namespace Sistema2025
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.ShowIcon = false;
            this.ControlBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void CerrarOtrosForms(Form keepOpen)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child != keepOpen)
                {
                    child.Close();
                }
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();

            CerrarOtrosForms(usuarios); 
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda agenda = new frmAgenda();
            agenda.MdiParent = this;
            agenda.Show();

            CerrarOtrosForms(agenda);
        }

        private void InventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario inventario = new frmInventario();
            inventario.MdiParent = this;
            inventario.Show();

            CerrarOtrosForms(inventario); 
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro registro = new frmRegistro();
            registro.MdiParent = this;
            registro.Show();

            CerrarOtrosForms(registro); 
        }
    }
}

