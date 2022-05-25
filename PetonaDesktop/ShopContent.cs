﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace PetonaDesktop
{
    public partial class ShopContent : UserControl
    {
        // inisialisasi koneksi ke database
        //string connStr = "server=sql6.freesqldatabase.com;port=3306;database=sql6492184;uid=sql6492184;pwd=MxvYZwjszD;";
        //string connStr = "server=127.0.0.1;port=3366;database=petona;uid=root;";
        string connStr = "server=localhost;port=3306;database=id18953733_petona;uid=id18953733_admin;pwd=Z{e5YY_pu1p(%+VE;";

        // inisialiasi variabel koneksi mysql
        MySqlConnection conn;

        public ShopContent()
        {
            InitializeComponent();

            // menghitung pergerakan scrolling content
            ScrollBar.Value = ShopFlowPanel.VerticalScroll.Value;
            ScrollBar.Minimum = ShopFlowPanel.VerticalScroll.Minimum;
            ScrollBar.Maximum = ShopFlowPanel.VerticalScroll.Maximum;

            // perubahan scrolling content
            ShopFlowPanel.ControlAdded += ShopFlowPanel_ControlAdded;
            ShopFlowPanel.ControlRemoved -= ShopFlowPanel_ControlRemoved;
        }

        // Inisialisasi nilai maximum content untuk scrolling
        private void ShopFlowPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            ScrollBar.Maximum = ShopFlowPanel.VerticalScroll.Maximum;
        }

        // Inisialisasi nilai minimum content untuk scrolling
        private void ShopFlowPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ScrollBar.Minimum = ShopFlowPanel.VerticalScroll.Minimum;
        }

        // fungsi untuk scroll content
        private void ScrollBar_Scroll_1(object sender, ScrollEventArgs e)
        {
            ShopFlowPanel.VerticalScroll.Value = ScrollBar.Value;
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


        // ketika ShopContent pertama kali diload
        private void ShopContent_Load(object sender, EventArgs e)
        {
            if (MysqlConnect())
            {
                MessageBox.Show("zuhal");
                return;
            }

            // cek koneksi mysql
            //if (MysqlConnect())
            //{
            //    string query = "SELECT * FROM products where id>1"; // table query mysql
            //    var cmd = new MySqlCommand(query, conn); // menjalankan query mysql
            //    var reader = cmd.ExecuteReader(); // fungsi untuk read table mysql
            //    //reader.Read();
            //    //string image = "https://petonaapi.000webhostapp.com/storage/" + reader.GetString(6);
            //    Console.WriteLine("zuhal");



            //    // read structure tabel products
            //    //while (reader.Read())
            //    //{
            //    //    // mengambil nama image
            //    //    string image = "https://petonaapi.000webhostapp.com/storage/" + reader.GetString(6);
            //    //    Console.WriteLine('');

            //    //    // mengambil nama produk
            //    //    string name = reader.GetString(2);

            //    //    // mengambil banyak produk
            //    //    string amount = reader.GetString(4);

            //    //    // mengambil harga produk
            //    //    string price = reader.GetString(5);


            //    //    // membuat komponen product
            //    //    Panel newPanel = new Panel()
            //    //    {
            //    //        Width = 300,
            //    //        Height = 455,
            //    //        BackColor = Color.White,
            //    //    };

            //    //    // menempatkan panel
            //    //    ShopFlowPanel.Controls.Add(newPanel);

            //    //    // membuat gambar produk
            //    //    newPanel.Controls.Add(new PictureBox()
            //    //    {
            //    //        ImageLocation = image,
            //    //        Width = 300,
            //    //        Height = 300,
            //    //        SizeMode = PictureBoxSizeMode.Zoom,
            //    //        Size = new Size(300,200)
            //    //    });

            //    //    // membuat label nama produk
            //    //    newPanel.Controls.Add(new Label()
            //    //    {
            //    //        Text = name,
            //    //        Location = new Point(81, 216),
            //    //        Size = new Size(150, 29),
            //    //        Font = new Font("Microsoft Sans Serif", 12)

            //    //    });

            //    //    // membuat label pieces
            //    //    newPanel.Controls.Add(new Label()
            //    //    {
            //    //        Text = amount + " pieces",
            //    //        Location = new Point(103, 245),
            //    //        Size = new Size(77, 20),
            //    //        Font = new Font("Microsoft Sans Serif", 8)
            //    //    });

            //    //    // membuat label harga
            //    //    newPanel.Controls.Add(new Label()
            //    //    {
            //    //        Text = "Rp. " + price + " /kg",
            //    //        Location = new Point(67, 362),
            //    //        Width =  166,
            //    //        Height = 29,
            //    //        Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold)
            //    //    });

            //    //    // membuat tombol
            //    //    newPanel.Controls.Add(new Button()
            //    //    {
            //    //        Text = "Masukkan Troli",
            //    //        Width = 202,
            //    //        Height = 31,
            //    //        Location = new Point(46, 399),
            //    //        Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold),
            //    //        ForeColor = Color.White,
            //    //        FlatStyle = FlatStyle.Flat,
            //    //        BackColor = Color.Green,
            //    //    });

            //    //}

            //    // keluar koneksi mysql
            //    //MysqlDisconnect();
            //}
        }
    }
}

