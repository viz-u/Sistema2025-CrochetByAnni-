namespace Sistema2025
{
    partial class frmRegistro
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
            plRegistro = new Panel();
            splitContainer1 = new SplitContainer();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnRegistrar = new Button();
            label11 = new Label();
            cboxAccionRegistro = new ComboBox();
            dateFechaRegistro = new DateTimePicker();
            label10 = new Label();
            numCantidad = new NumericUpDown();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            cboxProductoRegistro = new ComboBox();
            cboxMateriaRegistro = new ComboBox();
            lblUsuarios = new Label();
            panelHost = new Panel();
            toolStrip1.SuspendLayout();
            plRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
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
            toolStrip1.Size = new Size(94, 658);
            toolStrip1.TabIndex = 3;
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
            // plRegistro
            // 
            plRegistro.Controls.Add(splitContainer1);
            plRegistro.Controls.Add(lblUsuarios);
            plRegistro.Location = new Point(65, 42);
            plRegistro.Name = "plRegistro";
            plRegistro.Size = new Size(1179, 603);
            plRegistro.TabIndex = 4;
            plRegistro.Paint += plRegistro_Paint;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(341, 152);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label8);
            splitContainer1.Panel1.Controls.Add(label7);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnRegistrar);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Panel2.Controls.Add(cboxAccionRegistro);
            splitContainer1.Panel2.Controls.Add(dateFechaRegistro);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(numCantidad);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(cboxProductoRegistro);
            splitContainer1.Panel2.Controls.Add(cboxMateriaRegistro);
            splitContainer1.Size = new Size(751, 387);
            splitContainer1.SplitterDistance = 248;
            splitContainer1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(124, 291);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 17;
            label8.Text = "00.00$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(124, 235);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 16;
            label7.Text = "00.00$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(93, 70);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 15;
            label6.Text = "00.00$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 291);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 14;
            label5.Text = "Egresos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 235);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 13;
            label4.Text = "Ingresos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 31);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 0;
            label3.Text = "TOTAL";
            label3.Click += label3_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(275, 285);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(180, 34);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(34, 245);
            label11.Name = "label11";
            label11.Size = new Size(65, 25);
            label11.TabIndex = 19;
            label11.Text = "Acción";
            // 
            // cboxAccionRegistro
            // 
            cboxAccionRegistro.FormattingEnabled = true;
            cboxAccionRegistro.Items.AddRange(new object[] { "Ingreso", "Egreso" });
            cboxAccionRegistro.Location = new Point(34, 286);
            cboxAccionRegistro.Name = "cboxAccionRegistro";
            cboxAccionRegistro.Size = new Size(182, 33);
            cboxAccionRegistro.TabIndex = 18;
            cboxAccionRegistro.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // dateFechaRegistro
            // 
            dateFechaRegistro.Location = new Point(275, 170);
            dateFechaRegistro.Name = "dateFechaRegistro";
            dateFechaRegistro.Size = new Size(180, 31);
            dateFechaRegistro.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(275, 130);
            label10.Name = "label10";
            label10.Size = new Size(57, 25);
            label10.TabIndex = 16;
            label10.Text = "Fecha";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(275, 70);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(180, 31);
            numCantidad.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(275, 31);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 14;
            label9.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 31);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 12;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 130);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 13;
            label2.Text = "Materia Prima";
            // 
            // cboxProductoRegistro
            // 
            cboxProductoRegistro.FormattingEnabled = true;
            cboxProductoRegistro.Items.AddRange(new object[] { "Muñeco", "Llavero", "Flores", "Manta" });
            cboxProductoRegistro.Location = new Point(34, 72);
            cboxProductoRegistro.Name = "cboxProductoRegistro";
            cboxProductoRegistro.Size = new Size(182, 33);
            cboxProductoRegistro.TabIndex = 10;
            // 
            // cboxMateriaRegistro
            // 
            cboxMateriaRegistro.FormattingEnabled = true;
            cboxMateriaRegistro.Items.AddRange(new object[] { "Estambre", "Relleno" });
            cboxMateriaRegistro.Location = new Point(34, 172);
            cboxMateriaRegistro.Name = "cboxMateriaRegistro";
            cboxMateriaRegistro.Size = new Size(182, 33);
            cboxMateriaRegistro.TabIndex = 11;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Font = new Font("Lucida Sans", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarios.Location = new Point(15, 13);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(274, 55);
            lblUsuarios.TabIndex = 9;
            lblUsuarios.Text = "REGISTRO";
            // 
            // panelHost
            // 
            panelHost.BackgroundImage = Properties.Resources.fondo;
            panelHost.Controls.Add(plRegistro);
            panelHost.Dock = DockStyle.Fill;
            panelHost.Location = new Point(94, 0);
            panelHost.Name = "panelHost";
            panelHost.Size = new Size(1285, 658);
            panelHost.TabIndex = 5;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 658);
            Controls.Add(panelHost);
            Controls.Add(toolStrip1);
            Name = "frmRegistro";
            Text = "Registro";
            WindowState = FormWindowState.Maximized;
            Load += frmRegistro_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            plRegistro.ResumeLayout(false);
            plRegistro.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
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
        private Panel plRegistro;
        private Label lblUsuarios;
        private Panel panelHost;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label2;
        private ComboBox cboxProductoRegistro;
        private ComboBox cboxMateriaRegistro;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label11;
        private ComboBox cboxAccionRegistro;
        private DateTimePicker dateFechaRegistro;
        private Label label10;
        private NumericUpDown numCantidad;
        private Label label9;
        private Button btnRegistrar;
    }
}