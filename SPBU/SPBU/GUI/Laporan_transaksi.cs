using System;
using Microsoft.Reporting.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPBU.GUI
{
    public partial class Laporan_Transaksi : Form
    {
        Kelas.Koneksi konn = new Kelas.Koneksi();
        public static string idTransaksi;

        public Laporan_Transaksi()
        {
            InitializeComponent();
        }

        private void Laporan_Transaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTransaksi.DataTableTransaksi' table. You can move, or remove it, as needed.
            this.dataTableTransaksiTableAdapter.Fill(this.dataSetTransaksi.DataTableTransaksi);
            DataTable dt = new DataTable(); 
            SqlDataAdapter adapter = new SqlDataAdapter(); 
            SqlCommand cmd = new SqlCommand("SELECT        id_pengeluaran, deskripsi, jumlah_pengeluaran, tgl_pengeluaran, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL FROM            dbo.tbl_pengeluaran WHERE tgl_pengeluaran = '2018-11-29' UNION SELECT        NULL, NULL, NULL, NULL, id_transaksi, tgl_transaksi, id_transaksi_detail, id_pompa, nama_pompa, id_bbm, nama_bbm, stand_meter_awal, stand_meter_akhir, harga, total, NULL, NULL, NULL, NULL, NULL, NULL FROM            dbo.vtransaksi WHERE tgl_transaksi= '2018-11-29' UNION SELECT        NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, id_stok, id_bbm, nama_bbm, tgl_stok, jumlah_stok, harga FROM            dbo.vstock", konn.GetConn());
            adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet4_Transaksi", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
