namespace PetonaDesktop
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Passtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.Location = new System.Drawing.Point(29, 180);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(74, 29);
            this.EmailLabel.TabIndex = 17;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(31, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 3);
            this.panel2.TabIndex = 12;
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClearLabel.ForeColor = System.Drawing.Color.Green;
            this.ClearLabel.Location = new System.Drawing.Point(271, 351);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(116, 25);
            this.ClearLabel.TabIndex = 15;
            this.ClearLabel.Text = "Clear Fields";
            this.ClearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearLabel.Click += new System.EventHandler(this.ClearLabel_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ExitLabel.ForeColor = System.Drawing.Color.Green;
            this.ExitLabel.Location = new System.Drawing.Point(175, 460);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(61, 25);
            this.ExitLabel.TabIndex = 14;
            this.ExitLabel.Text = "EXIT";
            this.ExitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(31, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(31, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 3);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(80, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 40);
            this.label1.TabIndex = 10;
            this.label1.Text = "LOGIN PAGE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ImageLocation = "http://127.0.0.1:8000/storage/product-images/logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 78);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PassLabel.ForeColor = System.Drawing.Color.Black;
            this.PassLabel.Location = new System.Drawing.Point(31, 270);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(120, 29);
            this.PassLabel.TabIndex = 18;
            this.PassLabel.Text = "Password";
            this.PassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Emailtxt
            // 
            this.Emailtxt.BackColor = System.Drawing.Color.White;
            this.Emailtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Emailtxt.ForeColor = System.Drawing.Color.Black;
            this.Emailtxt.Location = new System.Drawing.Point(31, 186);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(350, 23);
            this.Emailtxt.TabIndex = 19;
            this.Emailtxt.Click += new System.EventHandler(this.Emailtxt_Click);
            // 
            // Passtxt
            // 
            this.Passtxt.BackColor = System.Drawing.Color.White;
            this.Passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Passtxt.ForeColor = System.Drawing.Color.Black;
            this.Passtxt.Location = new System.Drawing.Point(32, 278);
            this.Passtxt.Name = "Passtxt";
            this.Passtxt.Size = new System.Drawing.Size(349, 23);
            this.Passtxt.TabIndex = 20;
            this.Passtxt.Click += new System.EventHandler(this.Passtxt_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 571);
            this.Controls.Add(this.Passtxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ClearLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Passtxt;
    }
}