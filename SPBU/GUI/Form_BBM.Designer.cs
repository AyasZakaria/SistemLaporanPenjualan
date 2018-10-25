namespace SPBU.GUI
{
    partial class Form_BBM
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
            this.textBox_idBbm = new System.Windows.Forms.TextBox();
            this.textBox_namaBBM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_harga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_baru = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_simpan = new System.Windows.Forms.Button();
            this.dataGridView_bbm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bbm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID BBM";
            // 
            // textBox_idBbm
            // 
            this.textBox_idBbm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idBbm.Location = new System.Drawing.Point(115, 6);
            this.textBox_idBbm.Name = "textBox_idBbm";
            this.textBox_idBbm.Size = new System.Drawing.Size(173, 22);
            this.textBox_idBbm.TabIndex = 1;
            // 
            // textBox_namaBBM
            // 
            this.textBox_namaBBM.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_namaBBM.Location = new System.Drawing.Point(115, 34);
            this.textBox_namaBBM.Name = "textBox_namaBBM";
            this.textBox_namaBBM.Size = new System.Drawing.Size(173, 22);
            this.textBox_namaBBM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama BBM";
            // 
            // textBox_harga
            // 
            this.textBox_harga.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_harga.Location = new System.Drawing.Point(115, 62);
            this.textBox_harga.Name = "textBox_harga";
            this.textBox_harga.Size = new System.Drawing.Size(173, 22);
            this.textBox_harga.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga";
            // 
            // button_baru
            // 
            this.button_baru.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_baru.Location = new System.Drawing.Point(12, 99);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(90, 37);
            this.button_baru.TabIndex = 6;
            this.button_baru.Text = "Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            // 
            // button_hapus
            // 
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.Location = new System.Drawing.Point(140, 99);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(90, 37);
            this.button_hapus.TabIndex = 7;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            // 
            // button_ubah
            // 
            this.button_ubah.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ubah.Location = new System.Drawing.Point(261, 99);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(90, 37);
            this.button_ubah.TabIndex = 8;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            // 
            // button_simpan
            // 
            this.button_simpan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Location = new System.Drawing.Point(379, 99);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(90, 37);
            this.button_simpan.TabIndex = 9;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            // 
            // dataGridView_bbm
            // 
            this.dataGridView_bbm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_bbm.Location = new System.Drawing.Point(12, 159);
            this.dataGridView_bbm.Name = "dataGridView_bbm";
            this.dataGridView_bbm.Size = new System.Drawing.Size(456, 250);
            this.dataGridView_bbm.TabIndex = 10;
            // 
            // Form_BBM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 421);
            this.Controls.Add(this.dataGridView_bbm);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_ubah);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.button_baru);
            this.Controls.Add(this.textBox_harga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_namaBBM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_idBbm);
            this.Controls.Add(this.label1);
            this.Name = "Form_BBM";
            this.Text = "Form_BBM";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_bbm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_idBbm;
        private System.Windows.Forms.TextBox textBox_namaBBM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_harga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.DataGridView dataGridView_bbm;

    }
}