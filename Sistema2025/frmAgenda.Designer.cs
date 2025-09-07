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
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            plAgenda = new Panel();
            label3 = new Label();
            txtDesc = new TextBox();
            label2 = new Label();
            txtTitulo = new TextBox();
            label1 = new Label();
            dateFecha = new DateTimePicker();
            Recordatorios = new ListBox();
            lblUsuarios = new Label();
            panelHost = new Panel();
            toolStrip1.SuspendLayout();
            plAgenda.SuspendLayout();
            panelHost.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(218, 201, 228);
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripButton4, toolStripButton5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(94, 582);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DoubleClickEnabled = true;
            toolStripButton1.Image = Properties.Resources.add_document;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(89, 53);
            toolStripButton1.Text = "Nuevo";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.save;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(89, 53);
            toolStripButton2.Text = "Guardar";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = Properties.Resources.file_update;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(89, 53);
            toolStripButton3.Text = "Actualizar";
            toolStripButton3.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Image = Properties.Resources.trash;
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(89, 53);
            toolStripButton4.Text = "Eliminar";
            toolStripButton4.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            toolStripButton5.Image = Properties.Resources.logout;
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(89, 53);
            toolStripButton5.Text = "Cerrar";
            toolStripButton5.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // plAgenda
            // 
            plAgenda.Controls.Add(label3);
            plAgenda.Controls.Add(txtDesc);
            plAgenda.Controls.Add(label2);
            plAgenda.Controls.Add(txtTitulo);
            plAgenda.Controls.Add(label1);
            plAgenda.Controls.Add(dateFecha);
            plAgenda.Controls.Add(Recordatorios);
            plAgenda.Controls.Add(lblUsuarios);
            plAgenda.Location = new Point(38, 24);
            plAgenda.Name = "plAgenda";
            plAgenda.Size = new Size(634, 383);
            plAgenda.TabIndex = 2;
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
            // Recordatorios
            // 
            Recordatorios.FormattingEnabled = true;
            Recordatorios.ItemHeight = 25;
            Recordatorios.Location = new Point(294, 29);
            Recordatorios.Name = "Recordatorios";
            Recordatorios.Size = new Size(323, 329);
            Recordatorios.TabIndex = 9;
            Recordatorios.SelectedIndexChanged += Recordatorios_SelectedIndexChanged;
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
            panelHost.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private Panel plAgenda;
        private Label lblUsuarios;
        private ListBox Recordatorios;
        private DateTimePicker dateFecha;
        private Label label1;
        private Label label3;
        private TextBox txtDesc;
        private Label label2;
        private TextBox txtTitulo;
        private Panel panelHost;
    }
}