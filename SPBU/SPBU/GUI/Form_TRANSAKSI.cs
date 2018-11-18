using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SPBU.GUI
{
    public partial class Form_TRANSAKSI : Form
    {
        Kelas.Koneksi konn = new Kelas.Koneksi();
        public String id_bbm_transaksi;
        public String id_pompa1;
        public String id_pompa2;
        public String id_pompa3;
        public String id_pompa4;
        String id_transaksi_detail;

        public Form_TRANSAKSI()
        {
            InitializeComponent();
            clear();
            loadDaftar();
            
        }
        public DataSet getData()
        {
            DataSet dts = new DataSet();

            try
            {
                string sql = "SELECT * FROM vtransaksi"; SqlCommand command = new SqlCommand();
                command.Connection = konn.GetConn(); command.CommandType = CommandType.Text;
                command.CommandText = sql;
                SqlDataAdapter data = new SqlDataAdapter(command); data.Fill(dts, "vtransaksi");
            }//try

            catch (Exception e)
            {
                MessageBox.Show("get\n" + e.ToString());

            }//catch

            return dts;

        }//getData
        void header()
        {
            dataGridView_transaksi.Columns[0].HeaderText = "Id Transaksi";
            dataGridView_transaksi.Columns[1].HeaderText = "Tanggal Transaksi";
            dataGridView_transaksi.Columns[2].HeaderText = "Id Transaksi  Detail";
            dataGridView_transaksi.Columns[3].HeaderText = "Id Pompa";
            dataGridView_transaksi.Columns[4].HeaderText = "Nama Pompa";
            dataGridView_transaksi.Columns[5].HeaderText = "Id BBM";
            dataGridView_transaksi.Columns[6].HeaderText = "Nama BBM";
            dataGridView_transaksi.Columns[7].HeaderText = "Stand Meter Awal";
            dataGridView_transaksi.Columns[8].HeaderText = "Stand Meter Akhir";
            dataGridView_transaksi.Columns[9].HeaderText = "Harga";
            dataGridView_transaksi.Columns[10].HeaderText = "Total";
        }//header
        public void loadDaftar()
        {
            DataSet data = getData();
            dataGridView_transaksi.DataSource = data;
            dataGridView_transaksi.DataMember = "vtransaksi";
            header();
        }//loadDaftar
        public void clear()
        {
            textBox_idTransaksi.Clear();
            textBox_cari.Clear();
            //pertalite
            comboBox_namapompa_pertalite1.SelectedItem = "MESIN POMPA PERTALITE";
            comboBox_namapompa_pertalite2.SelectedItem = "MESIN POMPA PERTALITE";
            comboBox_namapompa_pertalite3.SelectedItem = "MESIN POMPA PERTALITE";
            comboBox_namapompa_pertalite4.SelectedItem = "MESIN POMPA PERTALITE";
            textBox_standAwalpertalitePompa1.Clear();
            textBox_standAwalpertalitePompa2.Clear();
            textBox_standAwalpertalitePompa3.Clear();
            textBox_standAwalpertalitePompa4.Clear();
            textBox_standAkhirPertalitePompa1.Clear();
            textBox_standAkhirPertalitePompa2.Clear();
            textBox_standAkhirPertalitePompa3.Clear();
            textBox_standAkhirPertalitePompa4.Clear();
            textBox_totalPertalitePompa1.Clear();
            textBox_totalPertalitePompa2.Clear();
            textBox_totalPertalitePompa3.Clear();
            textBox_totalPertalitePompa4.Clear();
            //pertamax
            comboBox_namapompa_pertamax1.SelectedItem = "MESIN POMPA PERTAMAX";
            comboBox_namapompa_pertamax2.SelectedItem = "MESIN POMPA PERTAMAX";
            comboBox_namapompa_pertamax3.SelectedItem = "MESIN POMPA PERTAMAX";
            comboBox_namapompa_pertamax4.SelectedItem = "MESIN POMPA PERTAMAX";
            textBox_standAwalPertamaxPompa1.Clear();
            textBox_standAwalPertamaxPompa2.Clear();
            textBox_standAwalPertamaxPompa3.Clear();
            textBox_standAwalPertamaxPompa4.Clear();
            textBox_standAkhirPertamaxPompa1.Clear();
            textBox_standAkhirPertamaxPompa2.Clear();
            textBox_standAkhirPertamaxPompa3.Clear();
            textBox_standAkhirPertamaxPompa4.Clear();
            textBox_totalPertamaxPompa1.Clear();
            textBox_totalPertamaxPompa2.Clear();
            textBox_totalPertamaxPompa3.Clear();
            textBox_totalPertamaxPompa4.Clear();
            //solar
            comboBox_namapompa_solat1.SelectedItem = "MESIN POMPA SOLAR";
            comboBox_namapompa_solat2.SelectedItem = "MESIN POMPA SOLAR";
            comboBox_namapompa_solat3.SelectedItem = "MESIN POMPA SOLAR";
            comboBox_namapompa_solat4.SelectedItem = "MESIN POMPA SOLAR";
            textBox_standAwalSolarPompa1.Clear();
            textBox_standAwalSolarPompa2.Clear();
            textBox_standAwalSolarPompa3.Clear();
            textBox_standAwalSolarPompa4.Clear();
            textBox_standAkhirSolarPompa1.Clear();
            textBox_standAkhirSolarPompa2.Clear();
            textBox_standAkhirSolarPompa3.Clear();
            textBox_standAkhirSolarPompa4.Clear();
            textBox_totalSolarPompa1.Clear();
            textBox_totalSolarPompa2.Clear();
            textBox_totalSolarPompa3.Clear();
            textBox_totalSolarPompa4.Clear();
            //premium
            comboBox_namapompa_premium1.SelectedItem = "MESIN POMPA PREMIUM";
            comboBox_namapompa_premium2.SelectedItem = "MESIN POMPA PREMIUM";
            comboBox_namapompa_premium3.SelectedItem = "MESIN POMPA PREMIUM";
            comboBox_namapompa_premium4.SelectedItem = "MESIN POMPA PREMIUM";
            textBox_standAwalPremiumPompa1.Clear();
            textBox_standAwalPremiumPompa2.Clear();
            textBox_standAwalPremiumPompa3.Clear();
            textBox_standAwalPremiumPompa4.Clear();
            textBox_standAkhirPremiumPompa1.Clear();
            textBox_standAkhirPremiumPompa2.Clear();
            textBox_standAkhirPremiumPompa3.Clear();
            textBox_standAkhirPremiumPompa4.Clear();
            textBox_totalPremiumPompa1.Clear();
            textBox_totalPremiumPompa2.Clear();
            textBox_totalPremiumPompa3.Clear();
            textBox_totalPremiumPompa4.Clear();

            aturTombol(false, false);
        }//clear
        public void aturTombol(bool param1, bool param2)
        {
            button_baru.Enabled = true;
            textBox_cari.Enabled = true;
            button_simpan.Enabled = param1;
            button_hapus.Enabled = param2;
            textBox_idTransaksi.Enabled = param1;
            //pertalite
            comboBox_namapompa_pertalite1.Enabled = param1;
            comboBox_namapompa_pertalite2.Enabled = param1;
            comboBox_namapompa_pertalite3.Enabled = param1;
            comboBox_namapompa_pertalite4.Enabled = param1;
            textBox_standAwalpertalitePompa1.Enabled = false;
            textBox_standAwalpertalitePompa2.Enabled = false;
            textBox_standAwalpertalitePompa3.Enabled = false;
            textBox_standAwalpertalitePompa4.Enabled = false;
            textBox_standAkhirPertalitePompa1.Enabled = param1;
            textBox_standAkhirPertalitePompa2.Enabled = param1;
            textBox_standAkhirPertalitePompa3.Enabled = param1;
            textBox_standAkhirPertalitePompa4.Enabled = param1;
            textBox_totalPertalitePompa1.Enabled = false;
            textBox_totalPertalitePompa2.Enabled = false;
            textBox_totalPertalitePompa3.Enabled = false;
            textBox_totalPertalitePompa4.Enabled = false;
            //Pertamax
            comboBox_namapompa_pertamax1.Enabled = param1;
            comboBox_namapompa_pertamax2.Enabled = param1;
            comboBox_namapompa_pertamax3.Enabled = false;
            comboBox_namapompa_pertamax4.Enabled = false;
            textBox_standAwalPertamaxPompa1.Enabled = false;
            textBox_standAwalPertamaxPompa2.Enabled = false;
            textBox_standAwalPertamaxPompa3.Enabled = false;
            textBox_standAwalPertamaxPompa4.Enabled = false;
            textBox_standAkhirPertamaxPompa1.Enabled = param1;
            textBox_standAkhirPertamaxPompa2.Enabled = param1;
            textBox_standAkhirPertamaxPompa3.Enabled = false;
            textBox_standAkhirPertamaxPompa4.Enabled = false;
            textBox_totalPertamaxPompa1.Enabled = false;
            textBox_totalPertamaxPompa2.Enabled = false;
            textBox_totalPertamaxPompa3.Enabled = false;
            textBox_totalPertamaxPompa4.Enabled = false;
            //premium
            comboBox_namapompa_premium1.Enabled = param1;
            comboBox_namapompa_premium2.Enabled = param1;
            comboBox_namapompa_premium3.Enabled = false;
            comboBox_namapompa_premium4.Enabled = false;
            textBox_standAwalPremiumPompa1.Enabled = false;
            textBox_standAwalPremiumPompa2.Enabled = false;
            textBox_standAwalPremiumPompa3.Enabled = false;
            textBox_standAwalPremiumPompa4.Enabled = false;
            textBox_standAkhirPremiumPompa1.Enabled = param1;
            textBox_standAkhirPremiumPompa2.Enabled = param1;
            textBox_standAkhirPremiumPompa3.Enabled = false;
            textBox_standAkhirPremiumPompa4.Enabled = false;
            textBox_totalPremiumPompa1.Enabled = false;
            textBox_totalPremiumPompa2.Enabled = false;
            textBox_totalPremiumPompa3.Enabled = false;
            textBox_totalPremiumPompa4.Enabled = false;
            //solar
            comboBox_namapompa_solat1.Enabled = param1;
            comboBox_namapompa_solat2.Enabled = param1;
            comboBox_namapompa_solat3.Enabled = false;
            comboBox_namapompa_solat4.Enabled = false;
            textBox_standAwalSolarPompa1.Enabled = false;
            textBox_standAwalSolarPompa2.Enabled = false;
            textBox_standAwalSolarPompa3.Enabled = false;
            textBox_standAwalSolarPompa4.Enabled = false;
            textBox_standAkhirSolarPompa1.Enabled = param1;
            textBox_standAkhirSolarPompa2.Enabled = param1;
            textBox_standAkhirSolarPompa3.Enabled = false;
            textBox_standAkhirSolarPompa4.Enabled = false;
            textBox_totalSolarPompa1.Enabled = false;
            textBox_totalSolarPompa2.Enabled = false;
            textBox_totalSolarPompa3.Enabled = false;
            textBox_totalSolarPompa4.Enabled = false;

            dateTimePicker_tglTransaksi.Enabled = param2;
        }//aturTombol 

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_TRANSAKSI_Load(object sender, EventArgs e)
        {

        }

        private void button_baru_Click(object sender, EventArgs e)
        {
            clear();
            aturTombol(true, false);
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            string id = id_transaksi_detail;
            DialogResult akses = MessageBox.Show("Apakah data Ini akan dihapus??", "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (akses == DialogResult.Yes)
            { //askes ke  controller 

                SqlCommand command = new SqlCommand();
                command.Connection = konn.GetConn();
                command.Connection.Open();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM tbl_transaksi_detail WHERE id_transaksi_detail='" + id + "'";
                command.ExecuteNonQuery();
                command.Connection.Close();//pesan berhasil 
                MessageBox.Show("Data Berhasil Dihapus", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); //memanggil tampil data 
                loadDaftar(); //memanggil bersih data 
                clear();
            }//if
        }

        private void dataGridView_transaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_idTransaksi.Text = dataGridView_transaksi.Rows[e.RowIndex].Cells[0].Value.ToString();
                dateTimePicker_tglTransaksi.Text = dataGridView_transaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
                id_transaksi_detail = dataGridView_transaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
                //3 id pompa
               // textBox_pompa1.Text = dataGridView_transaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
                //5 id bbm
                //textBox_namaBbm.Text = dataGridView_transaksi.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBox_standAwalpertalitePompa1.Text = dataGridView_transaksi.Rows[e.RowIndex].Cells[7].Value.ToString();
                textBox_standAkhirPertalitePompa1.Text = dataGridView_transaksi.Rows[e.RowIndex].Cells[8].Value.ToString();
                //9 harga
                textBox_totalPertalitePompa1.Text = dataGridView_transaksi.Rows[e.RowIndex].Cells[10].Value.ToString();
                aturTombol(true, true);
                button_simpan.Enabled = false;
            }//try 
            catch
            {
            }//catch
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand command = new SqlCommand();
                command.Connection = konn.GetConn();
                command.Connection.Open();
                command.CommandType = CommandType.Text;
              //  command.CommandText = "INSERT INTO tbl_penerimaan VALUES('" + textBox_idpenerimaan.Text + "','" + id_bbm_penerimaan + "','" + Convert.ToDateTime(dateTimePicker_penerimaan.Value).ToString("yyyy-MM-dd") + "','" + textBox_jumlahPenerimaan.Text + "')";
                command.ExecuteNonQuery();
                command.Connection.Close(); //pesan berhasil 
                MessageBox.Show("Data Berhasil Disimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); //memanggil tampil data 
                loadDaftar(); //memanggil bersih data 
                clear();
            }//try 

            catch (SqlException h)
            {
                MessageBox.Show("Gagal Simpan Data\n" + h, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }//catch
        }

        private void comboBox_namapompa_pertalite1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
