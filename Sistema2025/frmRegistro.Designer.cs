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
            label13 = new Label();
            dataGridView5 = new DataGridView();
            HISTORIAL = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label12 = new Label();
            label1 = new Label();
            dataGridView4 = new DataGridView();
            MOVIMIENTO = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            CARRITOVENTA = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            MATERIAPRIMA = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            PRODUCTOS = new DataGridViewTextBoxColumn();
            btnRegistrar = new Button();
            label11 = new Label();
            cboxAccionRegistro = new ComboBox();
            dateFechaRegistro = new DateTimePicker();
            label10 = new Label();
            numCantidad = new NumericUpDown();
            label9 = new Label();
            label2 = new Label();
            cboxMateriaRegistro = new ComboBox();
            lblUsuarios = new Label();
            panelHost = new Panel();
            toolStrip1.SuspendLayout();
            plRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            toolStrip1.Size = new Size(94, 690);
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
            plRegistro.Size = new Size(1208, 636);
            plRegistro.TabIndex = 4;
            plRegistro.Paint += plRegistro_Paint;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(30, 103);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label13);
            splitContainer1.Panel1.Controls.Add(dataGridView5);
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
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(dataGridView4);
            splitContainer1.Panel2.Controls.Add(dataGridView3);
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Panel2.Controls.Add(btnRegistrar);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Panel2.Controls.Add(cboxAccionRegistro);
            splitContainer1.Panel2.Controls.Add(dateFechaRegistro);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(numCantidad);
            splitContainer1.Panel2.Controls.Add(label9);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(cboxMateriaRegistro);
            splitContainer1.Size = new Size(1159, 517);
            splitContainer1.SplitterDistance = 382;
            splitContainer1.TabIndex = 14;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Lucida Sans", 15F, FontStyle.Bold);
            label13.Location = new Point(52, 31);
            label13.Name = "label13";
            label13.Size = new Size(148, 34);
            label13.TabIndex = 26;
            label13.Text = "Historial";
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { HISTORIAL });
            dataGridView5.Location = new Point(52, 79);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 62;
            dataGridView5.Size = new Size(276, 278);
            dataGridView5.TabIndex = 18;
            // 
            // HISTORIAL
            // 
            HISTORIAL.HeaderText = "Historial de Registros";
            HISTORIAL.MinimumWidth = 8;
            HISTORIAL.Name = "HISTORIAL";
            HISTORIAL.Width = 215;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(138, 441);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 17;
            label8.Text = "00.00$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(138, 405);
            label7.Name = "label7";
            label7.Size = new Size(66, 25);
            label7.TabIndex = 16;
            label7.Text = "00.00$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 373);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 15;
            label6.Text = "00.00$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 441);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 14;
            label5.Text = "Egresos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 405);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 13;
            label4.Text = "Ingresos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 371);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 0;
            label3.Text = "Total";
            label3.Click += label3_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Sans", 15F, FontStyle.Bold);
            label12.Location = new Point(428, 283);
            label12.Name = "label12";
            label12.Size = new Size(198, 34);
            label12.TabIndex = 26;
            label12.Text = "Movimiento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 15F, FontStyle.Bold);
            label1.Location = new Point(428, 31);
            label1.Name = "label1";
            label1.Size = new Size(103, 34);
            label1.TabIndex = 25;
            label1.Text = "Venta";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { MOVIMIENTO });
            dataGridView4.Location = new Point(428, 332);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new Size(314, 169);
            dataGridView4.TabIndex = 24;
            // 
            // MOVIMIENTO
            // 
            MOVIMIENTO.HeaderText = "Movimiento";
            MOVIMIENTO.MinimumWidth = 8;
            MOVIMIENTO.Name = "MOVIMIENTO";
            MOVIMIENTO.Width = 250;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { CARRITOVENTA });
            dataGridView3.Location = new Point(428, 91);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(314, 169);
            dataGridView3.TabIndex = 23;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // CARRITOVENTA
            // 
            CARRITOVENTA.HeaderText = "Venta";
            CARRITOVENTA.MinimumWidth = 8;
            CARRITOVENTA.Name = "CARRITOVENTA";
            CARRITOVENTA.Width = 250;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { MATERIAPRIMA });
            dataGridView2.Location = new Point(200, 91);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(182, 225);
            dataGridView2.TabIndex = 22;
            // 
            // MATERIAPRIMA
            // 
            MATERIAPRIMA.HeaderText = "Materias Primas";
            MATERIAPRIMA.MinimumWidth = 8;
            MATERIAPRIMA.Name = "MATERIAPRIMA";
            MATERIAPRIMA.Width = 150;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PRODUCTOS });
            dataGridView1.Location = new Point(12, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(182, 225);
            dataGridView1.TabIndex = 21;
            // 
            // PRODUCTOS
            // 
            PRODUCTOS.HeaderText = "Productos";
            PRODUCTOS.MinimumWidth = 8;
            PRODUCTOS.Name = "PRODUCTOS";
            PRODUCTOS.Width = 150;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(214, 37);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(113, 34);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "BUSCAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 11);
            label11.Name = "label11";
            label11.Size = new Size(65, 25);
            label11.TabIndex = 19;
            label11.Text = "Acción";
            // 
            // cboxAccionRegistro
            // 
            cboxAccionRegistro.FormattingEnabled = true;
            cboxAccionRegistro.Items.AddRange(new object[] { "Venta", "Movimiento" });
            cboxAccionRegistro.Location = new Point(12, 39);
            cboxAccionRegistro.Name = "cboxAccionRegistro";
            cboxAccionRegistro.Size = new Size(182, 33);
            cboxAccionRegistro.TabIndex = 18;
            cboxAccionRegistro.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // dateFechaRegistro
            // 
            dateFechaRegistro.Location = new Point(200, 371);
            dateFechaRegistro.Name = "dateFechaRegistro";
            dateFechaRegistro.Size = new Size(180, 31);
            dateFechaRegistro.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(200, 332);
            label10.Name = "label10";
            label10.Size = new Size(57, 25);
            label10.TabIndex = 16;
            label10.Text = "Fecha";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(12, 371);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(180, 31);
            numCantidad.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 332);
            label9.Name = "label9";
            label9.Size = new Size(83, 25);
            label9.TabIndex = 14;
            label9.Text = "Cantidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 405);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 13;
            label2.Text = "Materia Prima";
            // 
            // cboxMateriaRegistro
            // 
            cboxMateriaRegistro.FormattingEnabled = true;
            cboxMateriaRegistro.Items.AddRange(new object[] { "Ingreso", "Egreso" });
            cboxMateriaRegistro.Location = new Point(12, 433);
            cboxMateriaRegistro.Name = "cboxMateriaRegistro";
            cboxMateriaRegistro.Size = new Size(182, 33);
            cboxMateriaRegistro.TabIndex = 11;
            cboxMateriaRegistro.SelectedIndexChanged += cboxMateriaRegistro_SelectedIndexChanged;
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
            panelHost.Size = new Size(1285, 690);
            panelHost.TabIndex = 5;
            panelHost.Paint += panelHost_Paint;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1379, 690);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label2;
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
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private DataGridView dataGridView4;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn PRODUCTOS;
        private DataGridViewTextBoxColumn MATERIAPRIMA;
        private Label label12;
        private Label label1;
        private DataGridViewTextBoxColumn MOVIMIENTO;
        private DataGridViewTextBoxColumn CARRITOVENTA;
        private Label label13;
        private DataGridView dataGridView5;
        private DataGridViewTextBoxColumn HISTORIAL;
    }
}