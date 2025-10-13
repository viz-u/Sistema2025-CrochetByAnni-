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
            tsbtnNuevo = new ToolStripButton();
            tsbtnGuardar = new ToolStripButton();
            tsbtnActualizar = new ToolStripButton();
            tsbtnEliminar = new ToolStripButton();
            tsbtnSalir = new ToolStripButton();
            plUsuarios = new Panel();
            dgvUsuarios = new DataGridView();
            txtNombre = new TextBox();
            label4 = new Label();
            cboxTipoUsuario = new ComboBox();
            label3 = new Label();
            txtPasswordForm = new TextBox();
            txtUsuarioForm = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblUsuarios = new Label();
            panelHost = new Panel();
            toolStrip1.SuspendLayout();
            plUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panelHost.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(218, 201, 228);
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnNuevo, tsbtnGuardar, tsbtnActualizar, tsbtnEliminar, tsbtnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(94, 636);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNuevo
            // 
            tsbtnNuevo.Image = Properties.Resources.add_document;
            tsbtnNuevo.ImageTransparentColor = Color.Magenta;
            tsbtnNuevo.Name = "tsbtnNuevo";
            tsbtnNuevo.Size = new Size(89, 53);
            tsbtnNuevo.Text = "Nuevo";
            tsbtnNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtnNuevo.Click += tsbtnNuevo_Click;
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
            // tsbtnSalir
            // 
            tsbtnSalir.Image = Properties.Resources.logout;
            tsbtnSalir.ImageTransparentColor = Color.Magenta;
            tsbtnSalir.Name = "tsbtnSalir";
            tsbtnSalir.Size = new Size(89, 53);
            tsbtnSalir.Text = "Cerrar";
            tsbtnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbtnSalir.Click += tsbtnCerrar_Click;
            // 
            // plUsuarios
            // 
            plUsuarios.Controls.Add(dgvUsuarios);
            plUsuarios.Controls.Add(txtNombre);
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
            plUsuarios.Size = new Size(1040, 583);
            plUsuarios.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(470, 109);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.Size = new Size(547, 439);
            dgvUsuarios.TabIndex = 16;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(29, 146);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 31);
            txtNombre.TabIndex = 15;
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
            txtPasswordForm.PasswordChar = '*';
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
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
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
        private ToolStripButton tsbtnSalir;
        private Panel plUsuarios;
        private ComboBox cboxTipoUsuario;
        private Label label3;
        private TextBox txtPasswordForm;
        private TextBox txtUsuarioForm;
        private Label label2;
        private Label label1;
        private Label lblUsuarios;
        private Panel panelHost;

        private TextBox txtNombre;
        private Label label4;
        private DataGridView dgvUsuarios;
    }
}