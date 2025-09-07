namespace Sistema2025
{
    partial class frmInventario
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
            plInventario = new Panel();
            label2 = new Label();
            txtPrecioInv = new TextBox();
            label1 = new Label();
            cboxTipoInv = new ComboBox();
            label3 = new Label();
            txtNombreInv = new TextBox();
            lblUsuarios = new Label();
            panelHost = new Panel();
            toolStrip1.SuspendLayout();
            plInventario.SuspendLayout();
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
            toolStrip1.Size = new Size(94, 651);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
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
            // plInventario
            // 
            plInventario.Controls.Add(label2);
            plInventario.Controls.Add(txtPrecioInv);
            plInventario.Controls.Add(label1);
            plInventario.Controls.Add(cboxTipoInv);
            plInventario.Controls.Add(label3);
            plInventario.Controls.Add(txtNombreInv);
            plInventario.Controls.Add(lblUsuarios);
            plInventario.Location = new Point(37, 30);
            plInventario.Name = "plInventario";
            plInventario.Size = new Size(410, 393);
            plInventario.TabIndex = 3;
            plInventario.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(45, 270);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 16;
            label2.Text = "Precio";
            // 
            // txtPrecioInv
            // 
            txtPrecioInv.Location = new Point(45, 298);
            txtPrecioInv.Name = "txtPrecioInv";
            txtPrecioInv.PlaceholderText = "Escriba aqui...";
            txtPrecioInv.Size = new Size(150, 31);
            txtPrecioInv.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(45, 102);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 15;
            label1.Text = "Tipo";
            // 
            // cboxTipoInv
            // 
            cboxTipoInv.FormattingEnabled = true;
            cboxTipoInv.Items.AddRange(new object[] { "Producto", "Materia Prima" });
            cboxTipoInv.Location = new Point(45, 140);
            cboxTipoInv.Name = "cboxTipoInv";
            cboxTipoInv.Size = new Size(182, 33);
            cboxTipoInv.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(45, 192);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 12;
            label3.Text = "Nombre";
            // 
            // txtNombreInv
            // 
            txtNombreInv.Location = new Point(45, 220);
            txtNombreInv.Name = "txtNombreInv";
            txtNombreInv.PlaceholderText = "Escriba aqui...";
            txtNombreInv.Size = new Size(150, 31);
            txtNombreInv.TabIndex = 13;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarios.Location = new Point(28, 23);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(340, 55);
            lblUsuarios.TabIndex = 9;
            lblUsuarios.Text = "INVENTARIO";
            // 
            // panelHost
            // 
            panelHost.BackgroundImage = Properties.Resources.fondo;
            panelHost.Controls.Add(plInventario);
            panelHost.Dock = DockStyle.Fill;
            panelHost.Location = new Point(94, 0);
            panelHost.Name = "panelHost";
            panelHost.Size = new Size(1162, 651);
            panelHost.TabIndex = 4;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 651);
            Controls.Add(panelHost);
            Controls.Add(toolStrip1);
            Name = "frmInventario";
            Text = "Inventario";
            WindowState = FormWindowState.Maximized;
            Load += frmInventario_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            plInventario.ResumeLayout(false);
            plInventario.PerformLayout();
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
        private Panel plInventario;
        private Label lblUsuarios;
        private Label label1;
        private ComboBox cboxTipoInv;
        private Label label3;
        private TextBox txtNombreInv;
        private Label label2;
        private TextBox txtPrecioInv;
        private Panel panelHost;
    }
}