namespace Sistema2025
{
    partial class frmUsuarios
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
            plUsuarios = new Panel();
            textBox1 = new TextBox();
            label4 = new Label();
            cboxTipoUsuario = new ComboBox();
            label3 = new Label();
            txtPasswordForm = new TextBox();
            txtUsuarioForm = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblUsuarios = new Label();
            panelHost = new Panel();
            dataGridView1 = new DataGridView();
            toolStrip1.SuspendLayout();
            plUsuarios.SuspendLayout();
            panelHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            toolStrip1.Size = new Size(94, 636);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
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
            // plUsuarios
            // 
            plUsuarios.Controls.Add(dataGridView1);
            plUsuarios.Controls.Add(textBox1);
            plUsuarios.Controls.Add(label4);
            plUsuarios.Controls.Add(cboxTipoUsuario);
            plUsuarios.Controls.Add(label3);
            plUsuarios.Controls.Add(txtPasswordForm);
            plUsuarios.Controls.Add(txtUsuarioForm);
            plUsuarios.Controls.Add(label2);
            plUsuarios.Controls.Add(label1);
            plUsuarios.Controls.Add(lblUsuarios);
            plUsuarios.Location = new Point(74, 41);
            plUsuarios.Name = "plUsuarios";
            plUsuarios.Size = new Size(922, 583);
            plUsuarios.TabIndex = 1;
            plUsuarios.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(29, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 31);
            textBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 109);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 14;
            label4.Text = "Nombre:";
            // 
            // cboxTipoUsuario
            // 
            cboxTipoUsuario.FormattingEnabled = true;
            cboxTipoUsuario.Items.AddRange(new object[] { "General", "Administrador" });
            cboxTipoUsuario.Location = new Point(30, 403);
            cboxTipoUsuario.Name = "cboxTipoUsuario";
            cboxTipoUsuario.Size = new Size(261, 33);
            cboxTipoUsuario.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 363);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 12;
            label3.Text = "Tipo de Usuario:";
            // 
            // txtPasswordForm
            // 
            txtPasswordForm.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordForm.Location = new Point(30, 310);
            txtPasswordForm.Name = "txtPasswordForm";
            txtPasswordForm.Size = new Size(261, 31);
            txtPasswordForm.TabIndex = 11;
            // 
            // txtUsuarioForm
            // 
            txtUsuarioForm.BorderStyle = BorderStyle.FixedSingle;
            txtUsuarioForm.Location = new Point(30, 228);
            txtUsuarioForm.Name = "txtUsuarioForm";
            txtUsuarioForm.Size = new Size(261, 31);
            txtUsuarioForm.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 272);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 9;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 191);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 8;
            label1.Text = "Usuario:";
            label1.Click += label1_Click;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarios.Location = new Point(14, 22);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(279, 55);
            lblUsuarios.TabIndex = 7;
            lblUsuarios.Text = "USUARIOS";
            // 
            // panelHost
            // 
            panelHost.BackgroundImage = Properties.Resources.fondo;
            panelHost.Controls.Add(plUsuarios);
            panelHost.Dock = DockStyle.Fill;
            panelHost.Location = new Point(94, 0);
            panelHost.Name = "panelHost";
            panelHost.Size = new Size(1126, 636);
            panelHost.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(470, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 327);
            dataGridView1.TabIndex = 16;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 636);
            Controls.Add(panelHost);
            Controls.Add(toolStrip1);
            Name = "frmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Usuarios";
            WindowState = FormWindowState.Maximized;
            Load += frmUsuarios_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            plUsuarios.ResumeLayout(false);
            plUsuarios.PerformLayout();
            panelHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel plUsuarios;
        private ComboBox cboxTipoUsuario;
        private Label label3;
        private TextBox txtPasswordForm;
        private TextBox txtUsuarioForm;
        private Label label2;
        private Label label1;
        private Label lblUsuarios;
        private Panel panelHost;

        private TextBox textBox1;
        private Label label4;
        private DataGridView dataGridView1;
    }
}