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
    public partial class ContactContent : UserControl
    {
        public ContactContent()
        {
            InitializeComponent();

            // mengatur posisi dari Background image
            BackgroundImage.Location = new Point(3,14);
            BackgroundImage.SizeMode = PictureBoxSizeMode.Zoom;
            BackgroundImage.Size = new Size(1502, 596);
            BackgroundImage.Dock = DockStyle.Top;

            // mengatur posisi dan memberi border dari konten
            FeedbackContent.Location = new Point(170, 178);
            FeedbackContent.BorderStyle = BorderStyle.FixedSingle;

            // mengatur posisi dari title
            FeedbackTitle.Location = new Point(680, 88);
        }

        // membuat background dari title menjadi transparan
        private void ContactContent_Load(object sender, EventArgs e)
        {
            FeedbackTitle.Parent = BackgroundImage;
            FeedbackTitle.BackColor = Color.Transparent;
        }

        // merubah warna button dan cursor ketika cursor berada diatas tombol yes
        private void YesButton_MouseHover(object sender, EventArgs e)
        {
            YesButton.BackColor = Color.Lime;
            YesButton.ForeColor = Color.White;
            YesButton.Cursor = Cursors.Hand;
            
        }

        // mengembalikan cursor dan warna button keadaan semula
        private void YesButton_MouseLeave(object sender, EventArgs e)
        {
            YesButton.BackColor = Color.White;
            YesButton.ForeColor = Color.Black;
        }

        // merubah warna dan cursor ketika cursor berada diatas tombol no
        private void NoButton_MouseHover(object sender, EventArgs e)
        {
            NoButton.BackColor = Color.Lime;
            NoButton.ForeColor = Color.White;
            NoButton.Cursor = Cursors.Hand;
        }

        // mengembalikan cursor dan warna button keadaan semula
        private void NoButton_MouseLeave(object sender, EventArgs e)
        {
            NoButton.BackColor = Color.White;
            NoButton.ForeColor = Color.Black;
        }
    }
}
