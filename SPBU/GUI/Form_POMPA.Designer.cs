namespace SPBU.GUI
{
    partial class Form_POMPA
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
            this.textBox1_idPompa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_namaPompa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1_idBbm = new System.Windows.Forms.ComboBox();
            this.button4_simpan = new System.Windows.Forms.Button();
            this.button3_ubah = new System.Windows.Forms.Button();
            this.button2_hapus = new System.Windows.Forms.Button();
            this.button1_baru = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1_idPompa
            // 
            this.textBox1_idPompa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_idPompa.Location = new System.Drawing.Point(109, 6);
            this.textBox1_idPompa.Name = "textBox1_idPompa";
            this.textBox1_idPompa.Size = new System.Drawing.Size(173, 22);
            this.textBox1_idPompa.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Pompa";
            // 
            // textBox1_namaPompa
            // 
            this.textBox1_namaPompa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_namaPompa.Location = new System.Drawing.Point(109, 34);
            this.textBox1_namaPompa.Name = "textBox1_namaPompa";
            this.textBox1_namaPompa.Size = new System.Drawing.Size(173, 22);
            this.textBox1_namaPompa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nama Pompa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID BBM";
            // 
            // comboBox1_idBbm
            // 
            this.comboBox1_idBbm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1_idBbm.FormattingEnabled = true;
            this.comboBox1_idBbm.Location = new System.Drawing.Point(109, 62);
            this.comboBox1_idBbm.Name = "comboBox1_idBbm";
            this.comboBox1_idBbm.Size = new System.Drawing.Size(173, 21);
            this.comboBox1_idBbm.TabIndex = 8;
            // 
            // button4_simpan
            // 
            this.button4_simpan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4_simpan.Location = new System.Drawing.Point(380, 100);
            this.button4_simpan.Name = "button4_simpan";
            this.button4_simpan.Size = new System.Drawing.Size(90, 37);
            this.button4_simpan.TabIndex = 13;
            this.button4_simpan.Text = "Simpan";
            this.button4_simpan.UseVisualStyleBackColor = true;
            // 
            // button3_ubah
            // 
            this.button3_ubah.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3_ubah.Location = new System.Drawing.Point(255, 100);
            this.button3_ubah.Name = "button3_ubah";
            this.button3_ubah.Size = new System.Drawing.Size(90, 37);
            this.button3_ubah.TabIndex = 12;
            this.button3_ubah.Text = "Ubah";
            this.button3_ubah.UseVisualStyleBackColor = true;
            // 
            // button2_hapus
            // 
            this.button2_hapus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2_hapus.Location = new System.Drawing.Point(136, 100);
            this.button2_hapus.Name = "button2_hapus";
            this.button2_hapus.Size = new System.Drawing.Size(90, 37);
            this.button2_hapus.TabIndex = 11;
            this.button2_hapus.Text = "Hapus";
            this.button2_hapus.UseVisualStyleBackColor = true;
            // 
            // button1_baru
            // 
            this.button1_baru.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_baru.Location = new System.Drawing.Point(13, 100);
            this.button1_baru.Name = "button1_baru";
            this.button1_baru.Size = new System.Drawing.Size(90, 37);
            this.button1_baru.TabIndex = 10;
            this.button1_baru.Text = "Baru";
            this.button1_baru.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 250);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form_POMPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 429);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4_simpan);
            this.Controls.Add(this.button3_ubah);
            this.Controls.Add(this.button2_hapus);
            this.Controls.Add(this.button1_baru);
            this.Controls.Add(this.comboBox1_idBbm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1_namaPompa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1_idPompa);
            this.Controls.Add(this.label1);
            this.Name = "Form_POMPA";
            this.Text = "Form_POMPA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_idPompa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_namaPompa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1_idBbm;
        private System.Windows.Forms.Button button4_simpan;
        private System.Windows.Forms.Button button3_ubah;
        private System.Windows.Forms.Button button2_hapus;
        private System.Windows.Forms.Button button1_baru;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}