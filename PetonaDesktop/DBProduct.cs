using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetonaDesktop
{
    internal class DBProduct
    {
        // inisialisasi koneksi ke database
        string connStr = "server=127.0.0.1;port=3366;database=petona;uid=root;";

        // inisialiasi variabel koneksi mysql
        public MySqlConnection conn;

        public bool MysqlConnect()
        {
            // menghubungkan variabel koneksi ke database mysql
            conn = new MySqlConnection("server=127.0.0.1;port=3366;database=petona;uid=root;");

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
        public void MysqlDisconnect()
        {
            conn.Close();
        }

        public void Display(String query, DataGridView dgv)
        {
            string sql = query;
            conn = new MySqlConnection("server=127.0.0.1;port=3366;database=petona;uid=root;");
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            conn.Close();
        }
    }
}

