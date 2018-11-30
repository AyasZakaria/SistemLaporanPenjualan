namespace SPBU.GUI
{
    partial class menuUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOMPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pENGELUARANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pENERIMAANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.laporanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaksiToolStripMenuItem1});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // transaksiToolStripMenuItem1
            // 
            this.transaksiToolStripMenuItem1.Name = "transaksiToolStripMenuItem1";
            this.transaksiToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.transaksiToolStripMenuItem1.Text = "Transaksi";
            this.transaksiToolStripMenuItem1.Click += new System.EventHandler(this.transaksiToolStripMenuItem1_Click);
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bBMToolStripMenuItem,
            this.pOMPAToolStripMenuItem,
            this.pENGELUARANToolStripMenuItem,
            this.pENERIMAANToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // bBMToolStripMenuItem
            // 
            this.bBMToolStripMenuItem.Name = "bBMToolStripMenuItem";
            this.bBMToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.bBMToolStripMenuItem.Text = "BBM";
            this.bBMToolStripMenuItem.Click += new System.EventHandler(this.bBMToolStripMenuItem_Click);
            // 
            // pOMPAToolStripMenuItem
            // 
            this.pOMPAToolStripMenuItem.Name = "pOMPAToolStripMenuItem";
            this.pOMPAToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pOMPAToolStripMenuItem.Text = "POMPA";
            this.pOMPAToolStripMenuItem.Click += new System.EventHandler(this.pOMPAToolStripMenuItem_Click);
            // 
            // pENGELUARANToolStripMenuItem
            // 
            this.pENGELUARANToolStripMenuItem.Name = "pENGELUARANToolStripMenuItem";
            this.pENGELUARANToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pENGELUARANToolStripMenuItem.Text = "PENGELUARAN";
            this.pENGELUARANToolStripMenuItem.Click += new System.EventHandler(this.pENGELUARANToolStripMenuItem_Click);
            // 
            // pENERIMAANToolStripMenuItem
            // 
            this.pENERIMAANToolStripMenuItem.Name = "pENERIMAANToolStripMenuItem";
            this.pENERIMAANToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pENERIMAANToolStripMenuItem.Text = "PENERIMAAN";
            this.pENERIMAANToolStripMenuItem.Click += new System.EventHandler(this.pENERIMAANToolStripMenuItem_Click);
            // 
            // laporanToolStripMenuItem
            // 
            this.laporanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.harianToolStripMenuItem,
            this.bulanToolStripMenuItem});
            this.laporanToolStripMenuItem.Name = "laporanToolStripMenuItem";
            this.laporanToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.laporanToolStripMenuItem.Text = "Laporan";
            // 
            // harianToolStripMenuItem
            // 
            this.harianToolStripMenuItem.Name = "harianToolStripMenuItem";
            this.harianToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.harianToolStripMenuItem.Text = "Harian";
            this.harianToolStripMenuItem.Click += new System.EventHandler(this.harianToolStripMenuItem_Click);
            // 
            // bulanToolStripMenuItem
            // 
            this.bulanToolStripMenuItem.Name = "bulanToolStripMenuItem";
            this.bulanToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bulanToolStripMenuItem.Text = "Bulan";
            // 
            // menuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menuUtama";
            this.Text = "menuUtama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menuUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem bBMToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pOMPAToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pENGELUARANToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem laporanToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem harianToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem bulanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pENERIMAANToolStripMenuItem;
    }
}