namespace Sistema2025
{
    partial class frmLogin
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
            btnAcceder = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAcceder
            // 
            btnAcceder.Location = new Point(69, 320);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(90, 34);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += Acceder;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(41, 125);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(41, 210);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 153);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Escriba aqui...";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.ImeMode = ImeMode.Off;
            txtPassword.Location = new Point(41, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Escriba aqui...";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnAcceder);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(102, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 393);
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.log_in;
            pictureBox1.Location = new Point(69, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(213, 184, 209);
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(419, 507);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAcceder;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox txtPassword;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}