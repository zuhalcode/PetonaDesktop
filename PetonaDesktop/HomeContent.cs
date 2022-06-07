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
    public partial class HomeContent : UserControl
    {
        public HomeContent()
        {
            InitializeComponent();

            // inisialisasi posisi dan ukuran dari konten input produk, pemesanan, pelanggan
            InputProdukContent.SendToBack();
            InputProdukContent.Hide();
            InputProdukContent.Location = new Point(0, 0);
            InputProdukContent.Size = new Size(1650, 1145);

            PelangganContent.SendToBack();
            PelangganContent.Hide();
            PelangganContent.Location = new Point(0, 0);
            PelangganContent.Size = new Size(1650, 1145);

            PemesananContent.SendToBack();
            PemesananContent.Hide();
            PemesananContent.Location = new Point(0, 0);
            PemesananContent.Size = new Size(1650, 1145);
        }

        private void InputBarangButton_Click(object sender, EventArgs e)
        {
            // tampilkan InputProdukContent
            InputProdukContent.BringToFront();
            InputProdukContent.Show();
        }

        private void PemesananButton_Click(object sender, EventArgs e)
        {
            // tampilkan PemesananContent
            PemesananContent.BringToFront();
            PemesananContent.Show();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            // tampilkan PelangganContent
            PelangganContent.BringToFront();
            PelangganContent.Show();
        }

    }
}
