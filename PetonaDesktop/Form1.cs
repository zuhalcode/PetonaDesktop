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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // inisialisasi posisi awal setiap konten
            ShopContent.Location = new Point(270, 0);
            ShopContent.Size = new Size(1650, 1145);

            ContactContent.Location = new Point(270, 0);
            ContactContent.Size = new Size(1650, 1145);

            HomeContent.BringToFront();
            HomeContent.Location = new Point(270, 0);
            HomeContent.Size = new Size(1650, 1145);
        }

        // menempatkan konten ke posisi paling depan
        private void ShopBtn_Click(object sender, EventArgs e)
        {
            ShopContent.BringToFront();

        }

        // menempatkan konten ke posisi paling depan
        private void ContactBtn_Click(object sender, EventArgs e)
        {
            ContactContent.BringToFront();
        }

        // menempatkan konten ke posisi paling depan
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomeContent.BringToFront();
        }
    }
}
