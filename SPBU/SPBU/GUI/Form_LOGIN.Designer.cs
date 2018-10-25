namespace SPBU.GUI
{
    partial class Form_LOGIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_namaPengguna = new System.Windows.Forms.TextBox();
            this.textBox2_kataSandi = new System.Windows.Forms.TextBox();
            this.button1_login = new System.Windows.Forms.Button();
            this.button2_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Pengguna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kata Sandi";
            // 
            // textBox1_namaPengguna
            // 
            this.textBox1_namaPengguna.Location = new System.Drawing.Point(106, 64);
            this.textBox1_namaPengguna.Name = "textBox1_namaPengguna";
            this.textBox1_namaPengguna.Size = new System.Drawing.Size(100, 20);
            this.textBox1_namaPengguna.TabIndex = 2;
            // 
            // textBox2_kataSandi
            // 
            this.textBox2_kataSandi.Location = new System.Drawing.Point(106, 119);
            this.textBox2_kataSandi.Name = "textBox2_kataSandi";
            this.textBox2_kataSandi.PasswordChar = '*';
            this.textBox2_kataSandi.Size = new System.Drawing.Size(100, 20);
            this.textBox2_kataSandi.TabIndex = 3;
            // 
            // button1_login
            // 
            this.button1_login.Location = new System.Drawing.Point(25, 170);
            this.button1_login.Name = "button1_login";
            this.button1_login.Size = new System.Drawing.Size(75, 23);
            this.button1_login.TabIndex = 4;
            this.button1_login.Text = "Masuk";
            this.button1_login.UseVisualStyleBackColor = true;
            // 
            // button2_Exit
            // 
            this.button2_Exit.Location = new System.Drawing.Point(131, 170);
            this.button2_Exit.Name = "button2_Exit";
            this.button2_Exit.Size = new System.Drawing.Size(75, 23);
            this.button2_Exit.TabIndex = 5;
            this.button2_Exit.Text = "Exit";
            this.button2_Exit.UseVisualStyleBackColor = true;
            // 
            // Form_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 256);
            this.Controls.Add(this.button2_Exit);
            this.Controls.Add(this.button1_login);
            this.Controls.Add(this.textBox2_kataSandi);
            this.Controls.Add(this.textBox1_namaPengguna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_LOGIN";
            this.Text = "Form_LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_namaPengguna;
        private System.Windows.Forms.TextBox textBox2_kataSandi;
        private System.Windows.Forms.Button button1_login;
        private System.Windows.Forms.Button button2_Exit;
    }
}