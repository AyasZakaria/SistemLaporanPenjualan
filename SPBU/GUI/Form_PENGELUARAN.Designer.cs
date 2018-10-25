namespace SPBU.GUI
{
    partial class Form_PENGELUARAN
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_idBbm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_idPengeluaran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_ubah = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            this.button_baru = new System.Windows.Forms.Button();
            this.dataGridView_pengeluaran = new System.Windows.Forms.DataGridView();
            this.richTextBox_deskripsi = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pengeluaran)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Deskripsi";
            // 
            // textBox_idBbm
            // 
            this.textBox_idBbm.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idBbm.Location = new System.Drawing.Point(143, 40);
            this.textBox_idBbm.Name = "textBox_idBbm";
            this.textBox_idBbm.Size = new System.Drawing.Size(148, 22);
            this.textBox_idBbm.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jumlah Pengeluaran";
            // 
            // textBox_idPengeluaran
            // 
            this.textBox_idPengeluaran.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idPengeluaran.Location = new System.Drawing.Point(143, 12);
            this.textBox_idPengeluaran.Name = "textBox_idPengeluaran";
            this.textBox_idPengeluaran.Size = new System.Drawing.Size(148, 22);
            this.textBox_idPengeluaran.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Pengeluaran";
            // 
            // button_simpan
            // 
            this.button_simpan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_simpan.Location = new System.Drawing.Point(431, 138);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(96, 33);
            this.button_simpan.TabIndex = 71;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            // 
            // button_ubah
            // 
            this.button_ubah.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ubah.Location = new System.Drawing.Point(309, 138);
            this.button_ubah.Name = "button_ubah";
            this.button_ubah.Size = new System.Drawing.Size(96, 33);
            this.button_ubah.TabIndex = 70;
            this.button_ubah.Text = "Ubah";
            this.button_ubah.UseVisualStyleBackColor = true;
            // 
            // button_hapus
            // 
            this.button_hapus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hapus.Location = new System.Drawing.Point(191, 138);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(96, 33);
            this.button_hapus.TabIndex = 69;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            // 
            // button_baru
            // 
            this.button_baru.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_baru.Location = new System.Drawing.Point(73, 138);
            this.button_baru.Name = "button_baru";
            this.button_baru.Size = new System.Drawing.Size(96, 33);
            this.button_baru.TabIndex = 68;
            this.button_baru.Text = "Baru";
            this.button_baru.UseVisualStyleBackColor = true;
            // 
            // dataGridView_pengeluaran
            // 
            this.dataGridView_pengeluaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pengeluaran.Location = new System.Drawing.Point(16, 197);
            this.dataGridView_pengeluaran.Name = "dataGridView_pengeluaran";
            this.dataGridView_pengeluaran.Size = new System.Drawing.Size(568, 215);
            this.dataGridView_pengeluaran.TabIndex = 72;
            // 
            // richTextBox_deskripsi
            // 
            this.richTextBox_deskripsi.Location = new System.Drawing.Point(143, 68);
            this.richTextBox_deskripsi.Name = "richTextBox_deskripsi";
            this.richTextBox_deskripsi.Size = new System.Drawing.Size(336, 51);
            this.richTextBox_deskripsi.TabIndex = 73;
            this.richTextBox_deskripsi.Text = "";
            // 
            // Form_PENGELUARAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 423);
            this.Controls.Add(this.richTextBox_deskripsi);
            this.Controls.Add(this.dataGridView_pengeluaran);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.button_ubah);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.button_baru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_idBbm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_idPengeluaran);
            this.Controls.Add(this.label1);
            this.Name = "Form_PENGELUARAN";
            this.Text = "Form_PENGELUARAN";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pengeluaran)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_idBbm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_idPengeluaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_ubah;
        private System.Windows.Forms.Button button_hapus;
        private System.Windows.Forms.Button button_baru;
        private System.Windows.Forms.DataGridView dataGridView_pengeluaran;
        private System.Windows.Forms.RichTextBox richTextBox_deskripsi;
    }
}