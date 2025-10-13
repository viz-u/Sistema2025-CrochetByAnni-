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
            splitContainer1 = new SplitContainer();
            numericUpDown3 = new NumericUpDown();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            label3 = new Label();
            txtNombreInv = new TextBox();
            label2 = new Label();
            lblStock = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            lblSku = new Label();
            numericUpDown5 = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            textBox3 = new TextBox();
            numericUpDown4 = new NumericUpDown();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown2 = new NumericUpDown();
            label7 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            lblUsuarios = new Label();
            panelHost = new Panel();
            toolStrip1.SuspendLayout();
            plInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
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
            toolStrip1.Size = new Size(94, 779);
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
            plInventario.Controls.Add(splitContainer1);
            plInventario.Controls.Add(lblUsuarios);
            plInventario.Location = new Point(37, 30);
            plInventario.Name = "plInventario";
            plInventario.Size = new Size(1179, 718);
            plInventario.TabIndex = 3;
            plInventario.Paint += panel1_Paint;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(42, 100);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(numericUpDown3);
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            splitContainer1.Panel1.Controls.Add(label9);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(txtNombreInv);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(lblStock);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(numericUpDown1);
            splitContainer1.Panel1.Controls.Add(lblSku);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(numericUpDown5);
            splitContainer1.Panel2.Controls.Add(label12);
            splitContainer1.Panel2.Controls.Add(label11);
            splitContainer1.Panel2.Controls.Add(textBox5);
            splitContainer1.Panel2.Controls.Add(label10);
            splitContainer1.Panel2.Controls.Add(textBox3);
            splitContainer1.Panel2.Controls.Add(numericUpDown4);
            splitContainer1.Panel2.Controls.Add(dataGridView2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(textBox4);
            splitContainer1.Panel2.Controls.Add(label8);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Panel2.Controls.Add(numericUpDown2);
            splitContainer1.Panel2.Controls.Add(label7);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1113, 595);
            splitContainer1.SplitterDistance = 534;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 34;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(14, 197);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(208, 31);
            numericUpDown3.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(297, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(196, 291);
            dataGridView1.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Sans", 20F, FontStyle.Bold);
            label9.Location = new Point(3, 21);
            label9.Name = "label9";
            label9.Size = new Size(257, 45);
            label9.TabIndex = 33;
            label9.Text = "PRODUCTO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(14, 79);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 12;
            label3.Text = "Nombre";
            // 
            // txtNombreInv
            // 
            txtNombreInv.Location = new Point(14, 107);
            txtNombreInv.Name = "txtNombreInv";
            txtNombreInv.PlaceholderText = "Escriba aqui...";
            txtNombreInv.Size = new Size(208, 31);
            txtNombreInv.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(14, 157);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 16;
            label2.Text = "Precio";
            label2.Click += label2_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Location = new Point(14, 311);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(83, 25);
            lblStock.TabIndex = 20;
            lblStock.Text = "Cantidad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 264);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Escriba aqui...";
            textBox1.Size = new Size(208, 31);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(20, 339);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(202, 31);
            numericUpDown1.TabIndex = 21;
            // 
            // lblSku
            // 
            lblSku.AutoSize = true;
            lblSku.BackColor = Color.Transparent;
            lblSku.Location = new Point(14, 236);
            lblSku.Name = "lblSku";
            lblSku.Size = new Size(54, 25);
            lblSku.TabIndex = 20;
            lblSku.Text = "Clave";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(278, 465);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(176, 31);
            numericUpDown5.TabIndex = 42;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(278, 437);
            label12.Name = "label12";
            label12.Size = new Size(144, 25);
            label12.TabIndex = 41;
            label12.Text = "Minimo Reorden";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(12, 465);
            label11.Name = "label11";
            label11.Size = new Size(55, 25);
            label11.TabIndex = 39;
            label11.Text = "Color";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 493);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Escriba aqui...";
            textBox5.Size = new Size(182, 31);
            textBox5.TabIndex = 40;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(278, 360);
            label10.Name = "label10";
            label10.Size = new Size(46, 25);
            label10.TabIndex = 37;
            label10.Text = "Lote";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(278, 388);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Escriba aqui...";
            textBox3.Size = new Size(182, 31);
            textBox3.TabIndex = 38;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(17, 275);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(182, 31);
            numericUpDown4.TabIndex = 36;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(278, 79);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(196, 272);
            dataGridView2.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 20F, FontStyle.Bold);
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(306, 45);
            label1.TabIndex = 33;
            label1.Text = "Materia Prima";
            label1.Click += label1_Click_1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 197);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Escriba aqui...";
            textBox4.Size = new Size(182, 31);
            textBox4.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(12, 169);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 22;
            label8.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(12, 326);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 28;
            label4.Text = "Unidad";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Producto", "Materia Prima" });
            comboBox1.Location = new Point(12, 133);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 24;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(12, 422);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(176, 31);
            numericUpDown2.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(12, 92);
            label7.Name = "label7";
            label7.Size = new Size(47, 25);
            label7.TabIndex = 25;
            label7.Text = "Tipo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 354);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Escriba aqui...";
            textBox2.Size = new Size(182, 31);
            textBox2.TabIndex = 31;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(12, 247);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 26;
            label6.Text = "Costo";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(12, 394);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 29;
            label5.Text = "Cantidad";
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
            panelHost.Size = new Size(1248, 779);
            panelHost.TabIndex = 4;
            panelHost.Paint += panelHost_Paint;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 779);
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private Label label3;
        private TextBox txtNombreInv;
        private Label label2;
        private Panel panelHost;
        private NumericUpDown numericUpDown1;
        private Label lblStock;
        private Label lblSku;
        private TextBox textBox1;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private TextBox textBox4;
        private SplitContainer splitContainer1;
        private Label label1;
        private Label label9;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private Label label11;
        private TextBox textBox5;
        private Label label10;
        private TextBox textBox3;
        private Label label12;
        private NumericUpDown numericUpDown5;
    }
}