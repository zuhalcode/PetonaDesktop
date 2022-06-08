using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetonaDesktop
{
    public partial class PelangganContent : UserControl
    {
        // inisialisasi koneksi ke database
        string connStr = "server=127.0.0.1;port=3366;database=petona;uid=root;";

        // inisialiasi variabel koneksi mysql
        MySqlConnection conn;

        // koneksi ke mysql
        private bool MysqlConnect()
        {
            // menghubungkan variabel koneksi ke database mysql
            conn = new MySqlConnection(connStr);

            // ketika sukses terhubung
            try
            {
                // membuka koneksi database
                conn.Open();
                return true;
            }

            // error handling ketika gagal terhubung
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        // menutup koneksi mysql
        private void MysqlDisconnect()
        {
            conn.Close();
        }

        public PelangganContent()
        {
            InitializeComponent();
        }

        // tombol kembali
        private void KembaliButton_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Hide();
        }

        private void PelangganContent_Load(object sender, EventArgs e)
        {
            // menampilkan data Pelanggan
            DisplayData();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            // merefresh data Pelanggan
            DataCustomers.DataSource = "";
            DisplayData();
        }

        private void DisplayData()
        {
            // inisialisasi dataset dan datatable
            DataSet data = new DataSet();
            DataTable table = new DataTable();

            // menambahkan kolom pada table
            table.Columns.Add("#", typeof(int));
            table.Columns.Add("Nama Pelanggan");
            table.Columns.Add("Email Pelanggan");
            table.Columns.Add("Tanggal Pendaftaran");

            // cek koneksi mysql
            if (MysqlConnect())
            {
                string query = "SELECT * FROM users WHERE is_admin IS false"; // table query mysql
                var cmd = new MySqlCommand(query, conn); // menjalankan query mysql
                var reader = cmd.ExecuteReader(); // fungsi untuk read table mysql
                var number = 1; // nomor urut pada table

                // read structure tabel products
                while (reader.Read())
                {
                    // mengambil nama produk
                    string name = reader.GetString(1);

                    // mengambil banyak produk
                    string email = reader.GetString(2);

                    string createAt = reader.GetString(5);

                    // menambahkan data pada table
                    table.Rows.Add(number++, name, email, createAt);
                }

                // menambahkan table pada dataset
                data.Tables.Add(table);

                // menampilkan produk pada gridview
                DataCustomers.DataSource = data.Tables[0];

                //keluar koneksi mysql
                MysqlDisconnect();
            }
        }

        
    }
}
