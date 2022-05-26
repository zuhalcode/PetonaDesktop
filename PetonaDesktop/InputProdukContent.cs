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
    public partial class InputProdukContent : UserControl
    {
        public InputProdukContent()
        {
            InitializeComponent();
            
        }

        private void KembaliButton_Click(object sender, EventArgs e)
        {
            this.SendToBack(); 
        }
    }
}
