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
        }

        private void InputBarangButton_Click(object sender, EventArgs e)
        {
            new InputProdukContent().Show();
            this.Hide();
        }

        private void HomeContent_Load(object sender, EventArgs e)
        {

        }
    }
}
