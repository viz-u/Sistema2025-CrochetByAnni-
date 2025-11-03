    namespace Sistema2025
{
    partial class frmAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            tsbtnNuevo = new ToolStripButton();
            tsbtnGuardar = new ToolStripButton();
            tsbtnActualizar = new ToolStripButton();
            tsbtnEliminar = new ToolStripButton();
            tsbtnCerrar = new ToolStripButton();
            plAgenda = new Panel();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtDesc = new TextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            label1 = new Label();
            dateFecha = new DateTimePicker();
            lblUsuarios = new Label();
            panelHost = new Panel();
            toolStrip1.SuspendLayout();
            plAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelHost.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(218, 201, 228);
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnNuevo, tsbtnGuardar, tsbtnActualizar, tsbtnEliminar, tsbtnCerrar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(94, 582);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsbtnNuevo
            // 
            tsbtnNuevo.DoubleClickEnabled = true;
            tsbtnNuevo.Image = Properties.Resources.add_document;
            tsbtnNuevo.ImageTransparentColor = Color.Magenta;
            tsbtnNuevo.Name = "tsbtnNuevo";
            tsbtnNuevo.Size = new Size(89, 53);
            tsbtnNuevo.Text = "Nuevo";
            tsbtnNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtnNuevo.Click += toolStripButton1_Click;
            // 
            // tsbtnGuardar
            // 
            tsbtnGuardar.Image = Properties.Resources.save;
            tsbtnGuardar.ImageTransparentColor = Color.Magenta;
            tsbtnGuardar.Name = "tsbtnGuardar";
            tsbtnGuardar.Size = new Size(89, 53);
            tsbtnGuardar.Text = "Guardar";
            tsbtnGuardar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtnGuardar.Click += tsbtnGuardar_Click;
            // 
            // tsbtnActualizar
            // 
            tsbtnActualizar.Image = Properties.Resources.file_update;
            tsbtnActualizar.ImageTransparentColor = Color.Magenta;
            tsbtnActualizar.Name = "tsbtnActualizar";
            tsbtnActualizar.Size = new Size(89, 53);
            tsbtnActualizar.Text = "Actualizar";
            tsbtnActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtnActualizar.Click += tsbtnActualizar_Click;
            // 
            // tsbtnEliminar
            // 
            tsbtnEliminar.Image = Properties.Resources.trash;
            tsbtnEliminar.ImageTransparentColor = Color.Magenta;
            tsbtnEliminar.Name = "tsbtnEliminar";
            tsbtnEliminar.Size = new Size(89, 53);
            tsbtnEliminar.Text = "Eliminar";
            tsbtnEliminar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtnEliminar.Click += tsbtnEliminar_Click;
            // 
            // tsbtnCerrar
            // 
            tsbtnCerrar.Image = Properties.Resources.logout;
            tsbtnCerrar.ImageTransparentColor = Color.Magenta;
            tsbtnCerrar.Name = "tsbtnCerrar";
            tsbtnCerrar.Size = new Size(89, 53);
            tsbtnCerrar.Text = "Cerrar";
            tsbtnCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtnCerrar.Click += toolStripButton5_Click;
            // 
            // plAgenda
            // 
            plAgenda.Controls.Add(dataGridView1);
            plAgenda.Controls.Add(label3);
            plAgenda.Controls.Add(txtDesc);
            plAgenda.Controls.Add(label2);
            plAgenda.Controls.Add(txtTitulo);
            plAgenda.Controls.Add(label1);
            plAgenda.Controls.Add(dateFecha);
            plAgenda.Controls.Add(lblUsuarios);
            plAgenda.Location = new Point(38, 24);
            plAgenda.Name = "plAgenda";
            plAgenda.Size = new Size(1072, 546);
            plAgenda.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(409, 97);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(645, 431);
            dataGridView1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 241);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 15;
            label3.Text = "Fecha:";
            // 
            // txtDesc
            // 
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Location = new Point(16, 197);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(234, 31);
            txtDesc.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 169);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 13;
            label2.Text = "Descripción:";
            // 
            // txtTitulo
            // 
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.Location = new Point(16, 125);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(238, 31);
            txtTitulo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 97);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 11;
            label1.Text = "Titulo:";
            // 
            // dateFecha
            // 
            dateFecha.Location = new Point(15, 269);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(242, 31);
            dateFecha.TabIndex = 10;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarios.Location = new Point(16, 20);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(238, 55);
            lblUsuarios.TabIndex = 8;
            lblUsuarios.Text = "AGENDA";
            // 
            // panelHost
            // 
            panelHost.BackgroundImage = Properties.Resources.fondo;
            panelHost.Controls.Add(plAgenda);
            panelHost.Dock = DockStyle.Fill;
            panelHost.Location = new Point(94, 0);
            panelHost.Name = "panelHost";
            panelHost.Size = new Size(1146, 582);
            panelHost.TabIndex = 3;
            panelHost.Paint += panelHost_Paint;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 582);
            Controls.Add(panelHost);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda";
            WindowState = FormWindowState.Maximized;
            Load += frmAgenda_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            plAgenda.ResumeLayout(false);
            plAgenda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelHost.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnNuevo;
        private ToolStripButton tsbtnGuardar;
        private ToolStripButton tsbtnActualizar;
        private ToolStripButton tsbtnEliminar;
        private ToolStripButton tsbtnCerrar;
        private Panel plAgenda;
        private Label lblUsuarios;
        private DateTimePicker dateFecha;
        private Label label1;
        private Label label3;
        private TextBox txtDesc;
        private Label label2;
        private TextBox txtTitulo;
        private Panel panelHost;
        private DataGridView dataGridView1;
    }
}