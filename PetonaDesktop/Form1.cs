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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HomeContent.BringToFront();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomeContent.BringToFront();
        }

        private void ShopBtn_Click(object sender, EventArgs e)
        {
            ShopContent.BringToFront();
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            ContactContent.BringToFront();
        }
    }
}
