using MySql.Data.MySqlClient;
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
        // inisialisasi lokasi image global
        static string imageLoc;

        // inisialisasi koneksi ke database
        string connStr = "server=127.0.0.1;port=3366;database=petona;uid=root;";

        // inisialiasi variabel koneksi mysql
        MySqlConnection conn;

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
            

            DisplayData();
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

        // merubah warna dan cursor ketika cursor berada diatas tombol no
        private void SubmitBtn_MouseHover(object sender, EventArgs e)
        {
            SubmitBtn.BackColor = Color.Lime;
            SubmitBtn.ForeColor = Color.White;
            SubmitBtn.Cursor = Cursors.Hand;
        }

        // mengembalikan cursor dan warna button keadaan semula
        private void SubmitBtn_MouseLeave(object sender, EventArgs e)
        {
            SubmitBtn.BackColor = Color.White;
            SubmitBtn.ForeColor = Color.Black;
        }



        // menampilkan data feedback
        private void DisplayData()
        {
            // koneksi ke database
            if (MysqlConnect())
            {
                string query = "SELECT name,feedback FROM `feedbacks` JOIN users ON feedbacks.user_id = users.id"; // table query mysql
                var cmd = new MySqlCommand(query, conn); // menjalankan query mysql
                var reader = cmd.ExecuteReader(); // fungsi untuk read table mysql
                while (reader.Read())
                {
                    // mengambil nama produk
                    string name = reader.GetString(0);

                    string feedback = reader.GetString(1);

                    // membuat panel feedback
                    Panel panelFeed = new Panel()
                    {
                        Size = new Size(559, 117),
                        BackColor = Color.Turquoise,
                    };

                    // membuat icon image
                    panelFeed.Controls.Add(new PictureBox()
                    {
                        ImageLocation = "E:\\default-user.png",
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(69, 67),
                        Location = new Point(6, 14)
                    });

                    // membuat label nama
                    panelFeed.Controls.Add(new Label()
                    {
                        Text = name,
                        Location = new Point(96, 20),
                        Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),

                    });

                    // membuat label tanggal dibuat
                    panelFeed.Controls.Add(new Label()
                    {
                        Text = "3 Hari yang lalu",
                        Location = new Point(97, 47),
                        ForeColor = Color.White,
                        Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold),
                        AutoSize = true

                    });

                    // membuat label feedback
                    panelFeed.Controls.Add(new Label()
                    {
                        Text = $"\"{feedback}\"",
                        Location = new Point(4, 86),
                        Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold),
                        BackColor = Color.Turquoise,
                        AutoSize = true

                    });

                    // menampilkan feedback
                    FlowFeedbacks.Controls.Add(panelFeed);
                }

                // menutup koneksi database
                MysqlDisconnect();
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (MysqlConnect())
            {
                // cek apakah inputan kosong
                if(NameInput.Text == "" || FeedbackInput.Text == "" )
                {
                    MessageBox.Show("Komentar atau nama tidak boleh kosong");
                }
                else
                {
                    string name = NameInput.Text; // mengambil input nama
                    string feedback = FeedbackInput.Text; // mengambil input komentar
                    DateTime time = DateTime.Now;

                    string query = $"INSERT INTO guest_feedbacks VALUES('',\'{name}\', \'{feedback}\', \'{time.ToString("yyyy-MM-dd HH:mm")}\', '')"; // table query mysql
                    var cmd = new MySqlCommand(query, conn); // menjalankan query mysql
                    cmd.ExecuteReader(); // fungsi untuk read table mysql

                    // mengosongkan input
                    NameInput.Text = "";
                    FeedbackInput.Text = "";

                    // merefresh data feedback
                    FlowFeedbacks.Controls.Clear();
                    DisplayNewFeedback();
                    DisplayData();

                    // pesan sukses
                    MessageBox.Show("Terima Kasih sudah memberikan komentar");

                    // menutup koneksi database
                    MysqlDisconnect();
                }
                
            }
        }

        private void DisplayNewFeedback()
        {
            // koneksi ke database
            if (MysqlConnect())
            {
                string query = "SELECT name,feedback,created_at FROM `guest_feedbacks` ORDER BY created_at DESC"; // table query mysql
                var cmd = new MySqlCommand(query, conn); // menjalankan query mysql
                var reader = cmd.ExecuteReader(); // fungsi untuk read table mysql
                while (reader.Read())
                {
                    // mengambil nama produk
                    string name = reader.GetString(0);

                    string feedback = reader.GetString(1);

                    string time = reader.GetString(2);


                    // membuat panel feedback
                    Panel panelFeed = new Panel()
                    {
                        Size = new Size(559, 117),
                        BackColor = Color.Turquoise,
                    };

                    // membuat icon image
                    panelFeed.Controls.Add(new PictureBox()
                    {
                        ImageLocation = "E:\\default-user.png",
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Size = new Size(69, 67),
                        Location = new Point(6, 14)
                    });

                    // membuat label nama
                    panelFeed.Controls.Add(new Label()
                    {
                        Text = name,
                        Location = new Point(96, 20),
                        Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),

                    });

                    // membuat label tanggal dibuat
                    panelFeed.Controls.Add(new Label()
                    {
                        Text = time,
                        Location = new Point(97, 47),
                        ForeColor = Color.White,
                        Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold),
                        AutoSize = true

                    });

                    // membuat label feedback
                    panelFeed.Controls.Add(new Label()
                    {
                        Text = $"\"{feedback}\"",
                        Location = new Point(4, 86),
                        Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold),
                        BackColor = Color.Turquoise,
                        AutoSize = true

                    });

                    // menampilkan feedback
                    FlowFeedbacks.Controls.Add(panelFeed);
                }

                // menutup koneksi database
                MysqlDisconnect();
            }
        }

        // menampilkan pesan ketika diklik
        private void YesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terima Kasih");
        }
    }
}
