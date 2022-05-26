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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            EmailLabel.BringToFront();
            PassLabel.BringToFront();

        }

        private void Emailtxt_Click(object sender, EventArgs e)
        {
            EmailLabel.Location = new Point(17, 103);
            EmailLabel.Font = new Font("Microsoft Sans Serif",10);
            EmailLabel.ForeColor = Color.Green;
        }


        private void Passtxt_Click(object sender, EventArgs e)
        {
            PassLabel.Location = new Point(17, 160);
            PassLabel.Font = new Font("Microsoft Sans Serif", 10);
            PassLabel.ForeColor = Color.Green;
            Passtxt.UseSystemPasswordChar = true;

        }

        private void ExitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            Emailtxt.Clear();
            Passtxt.Clear();
            Emailtxt.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
