using System;
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
        string connStr = "server=sql6.freesqldatabase.com;port=3306;database=sql6492184;uid=sql6492184;pwd=MxvYZwjszD;";
        MySqlConnection conn;
        public ShopContent()
        {
            InitializeComponent();

            ScrollBar.Value = ShopFlowPanel.VerticalScroll.Value;
            ScrollBar.Minimum = ShopFlowPanel.VerticalScroll.Minimum;
            ScrollBar.Maximum = ShopFlowPanel.VerticalScroll.Maximum;

            ShopFlowPanel.ControlAdded += ShopFlowPanel_ControlAdded;
            ShopFlowPanel.ControlRemoved -= ShopFlowPanel_ControlRemoved;
        }

        private void ShopFlowPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            ScrollBar.Maximum = ShopFlowPanel.VerticalScroll.Maximum;
        }

        private void ShopFlowPanel_ControlRemoved(object sender, ControlEventArgs e)
        {
            ScrollBar.Minimum = ShopFlowPanel.VerticalScroll.Minimum;
        }

        private bool MysqlConnect()
        {
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void MysqlDisconnect()
        {
            conn.Close();
        }

        private void TesConnect_Click(object sender, EventArgs e)
        {
            if (MysqlConnect())
            {
                MessageBox.Show("Terkoneksi dengan database");
            }
        }

        private void ScrollBar_Scroll_1(object sender, ScrollEventArgs e)
        {
            ShopFlowPanel.VerticalScroll.Value = ScrollBar.Value;
        }

        private void ShopContent_Load(object sender, EventArgs e)
        {
            // koneksi ke mysql
            if (MysqlConnect())
            {
                string query = "SELECT * FROM products";
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();
                reader.Read();  
                string image = "http://127.0.0.1:8000/storage/" + reader.GetString(6);
                Console.WriteLine(image);
                Panel newPanel = new Panel();
                newPanel.Controls.Add(new PictureBox()
                {
                    ImageLocation = image,
                    Width = 250,
                    Height = 300,
                    SizeMode = PictureBoxSizeMode.Zoom
                });

                // read structure tabel products
                //while (reader.Read())
                //{
                //    string image = "http://127.0.0.1:8000/storage/" + reader.GetString(6);
                //    Panel newPanel = new Panel();
                //    newPanel.Controls.Add(new PictureBox()
                //    {
                //        ImageLocation = image,
                //        Width = 250,
                //        Height = 300,
                //        SizeMode = PictureBoxSizeMode.Zoom
                //    });

                //}
                MysqlDisconnect();
            }
        }

        //private void CreatePanels(int Number)
        //{
        //    for(int i = 0; i < Number; i++)
        //    {
        //        Panel temp = new Panel();
        //        this.Controls.Add(temp);
        //        temp.Width = 250;
        //        temp.Height = 300;
        //        temp.BackColor = Color.Red;
        //        ProductPanel.Controls.Add(temp);
        //    }
        //}
    }
}

