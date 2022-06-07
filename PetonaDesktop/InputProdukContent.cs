using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetonaDesktop
{
    public partial class InputProdukContent : UserControl
    {
        // inisialisasi lokasi image global
        static string imageLoc;

        // inisialisasi koneksi ke database
        string connStr = "server=127.0.0.1;port=3366;database=petona;uid=root;";

        // inisialiasi variabel koneksi mysql
        MySqlConnection conn;

        public InputProdukContent()
        {
            InitializeComponent();
        }

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

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Hide();
        }

        private void PicUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLoc = openFileDialog.FileName;
                    ProductPic.ImageLocation = imageLoc;
                    Console.WriteLine(imageLoc);
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                Product product = new Product()
                {
                    name = ProductName.Text,
                    category = 1,
                    description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Asperiores, facere.",
                    amount = ProductAmount.Text,
                    price = ProductPrice.Text,
                    image = imageLoc
                };

                var endpoint = new Uri("http://127.0.0.1:8000/api/products/add");
                var productJson = JsonConvert.SerializeObject(product);
                Console.WriteLine(productJson);
                var payload = new StringContent(productJson, Encoding.UTF8, "application/json");
                var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
            }

            DataProducts.DataSource = "";
            DisplayProduct();

        }

        private void InputProdukContent_Load(object sender, EventArgs e)
        {
            DisplayProduct();
        }

        public void DisplayProduct()
        {
            DataSet data = new DataSet();
            DataTable table = new DataTable();
            table.Columns.Add("#", typeof(int));
            table.Columns.Add("Nama Produk");
            table.Columns.Add("Stok Produk");
            table.Columns.Add("Harga Produk");

            if (MysqlConnect())
            {
                string query = "SELECT * FROM products where id>1 "; // table query mysql
                var cmd = new MySqlCommand(query, conn); // menjalankan query mysql
                var reader = cmd.ExecuteReader(); // fungsi untuk read table mysql
                var number = 1;
                while (reader.Read())
                {
                    // mengambil nama produk
                    string name = reader.GetString(2);

                    // mengambil banyak produk
                    string amount = reader.GetString(4);

                    // mengambil harga produk
                    string price = reader.GetString(5);

                    table.Rows.Add(number++, name, amount, price);

                }
                data.Tables.Add(table);
                DataProducts.DataSource = data.Tables[0];

                MysqlDisconnect();
            }
        }
    }
}
