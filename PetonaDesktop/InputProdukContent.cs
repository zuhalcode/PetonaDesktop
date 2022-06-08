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

        // tombol untuk kembali
        private void KembaliButton_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Hide();
        }

        // tombol untuk upload image
        private void PicUpload_Click(object sender, EventArgs e)
        {
            try
            {
                // inisialisasi variable untuk membuka folder pada file explorer
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // filter file yang akan ditampilkan pada fileDialog
                openFileDialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All files(*.*)|*.*";

                // jika file sudah dipilih
                if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // mengubah image location sesuai nama file
                    imageLoc = openFileDialog.FileName;

                    // menampilkan image
                    ProductPic.ImageLocation = imageLoc;
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            // http request post untuk create produk
            using (HttpClient client = new HttpClient())
            {
                // inisialisasi produk yang akan diinputkan
                Product product = new Product()
                {
                    name = ProductName.Text,
                    category = 1,
                    description = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Asperiores, facere.",
                    amount = ProductAmount.Text,
                    price = ProductPrice.Text,
                    image = imageLoc
                };

                // url request API
                var endpoint = new Uri("http://127.0.0.1:8000/api/products/add");

                // convert data produk menjadi JSON
                var productJson = JsonConvert.SerializeObject(product);
                var payload = new StringContent(productJson, Encoding.UTF8, "application/json");

                // hasil dari post request API
                var result = client.PostAsync(endpoint, payload).Result.Content.ReadAsStringAsync().Result;
            }

            // merefresh data produk
            DataProducts.DataSource = "";
            DisplayProduct();

            // mengosongkan textbox setelah data diinputkan
            ProductName.Text = "";
            ProductAmount.Text = "";
            ProductPrice.Text = "";
            ProductPic.ImageLocation = "";

            // pesan sukses
            MessageBox.Show("Produk Berhasil Ditambahkan");

        }

        private void InputProdukContent_Load(object sender, EventArgs e)
        {
            // menampilkan produk ketika pertama di load
            DisplayProduct();
        }

        public void DisplayProduct()
        {
            // inisialisasi dataset dan datatable
            DataSet data = new DataSet();
            DataTable table = new DataTable();

            // menambahkan kolom pada table
            table.Columns.Add("#", typeof(int));
            table.Columns.Add("Nama Produk");
            table.Columns.Add("Stok Produk");
            table.Columns.Add("Harga Produk");

            // koneksi ke database
            if (MysqlConnect())
            {
                string query = "SELECT * FROM products WHERE id>1 "; // table query mysql
                var cmd = new MySqlCommand(query, conn); // menjalankan query mysql
                var reader = cmd.ExecuteReader(); // fungsi untuk read table mysql
                var number = 1; // nomor urut pada table
                while (reader.Read())
                {
                    // mengambil nama produk
                    string name = reader.GetString(2);

                    // mengambil banyak produk
                    string amount = reader.GetString(4);

                    // mengambil harga produk
                    string price = reader.GetString(5);

                    // menambahkan data pada table
                    table.Rows.Add(number++, name, amount, price);

                }
                // menambahkan table pada dataset
                data.Tables.Add(table);

                // menampilkan produk pada gridview
                DataProducts.DataSource = data.Tables[0];

                // menutup koneksi database
                MysqlDisconnect();
            }
        }
    }
}
