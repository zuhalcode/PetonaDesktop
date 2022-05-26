namespace PetonaDesktop
{
    partial class Form1
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ContactBtn = new FontAwesome.Sharp.IconButton();
            this.ShopBtn = new FontAwesome.Sharp.IconButton();
            this.HomeBtn = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeContent = new PetonaDesktop.HomeContent();
            this.ShopContent = new PetonaDesktop.ShopContent();
            this.ContactContent = new PetonaDesktop.ContactContent();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.LimeGreen;
            this.PanelMenu.Controls.Add(this.ContactBtn);
            this.PanelMenu.Controls.Add(this.ShopBtn);
            this.PanelMenu.Controls.Add(this.HomeBtn);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(178, 487);
            this.PanelMenu.TabIndex = 0;
            // 
            // ContactBtn
            // 
            this.ContactBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContactBtn.ForeColor = System.Drawing.Color.White;
            this.ContactBtn.IconChar = FontAwesome.Sharp.IconChar.Phone;
            this.ContactBtn.IconColor = System.Drawing.Color.White;
            this.ContactBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ContactBtn.IconSize = 38;
            this.ContactBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ContactBtn.Location = new System.Drawing.Point(0, 145);
            this.ContactBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Padding = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.ContactBtn.Size = new System.Drawing.Size(178, 51);
            this.ContactBtn.TabIndex = 3;
            this.ContactBtn.Text = "      CONTACT";
            this.ContactBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ContactBtn.UseVisualStyleBackColor = true;
            this.ContactBtn.Click += new System.EventHandler(this.ContactBtn_Click);
            // 
            // ShopBtn
            // 
            this.ShopBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShopBtn.FlatAppearance.BorderSize = 0;
            this.ShopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopBtn.ForeColor = System.Drawing.Color.White;
            this.ShopBtn.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.ShopBtn.IconColor = System.Drawing.Color.White;
            this.ShopBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ShopBtn.IconSize = 38;
            this.ShopBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShopBtn.Location = new System.Drawing.Point(0, 109);
            this.ShopBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShopBtn.Name = "ShopBtn";
            this.ShopBtn.Padding = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.ShopBtn.Size = new System.Drawing.Size(178, 36);
            this.ShopBtn.TabIndex = 2;
            this.ShopBtn.Text = "      SHOP";
            this.ShopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShopBtn.UseVisualStyleBackColor = true;
            this.ShopBtn.Click += new System.EventHandler(this.ShopBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.HomeBtn.IconColor = System.Drawing.Color.White;
            this.HomeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HomeBtn.IconSize = 38;
            this.HomeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBtn.Location = new System.Drawing.Point(0, 73);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Padding = new System.Windows.Forms.Padding(3, 0, 7, 0);
            this.HomeBtn.Size = new System.Drawing.Size(178, 36);
            this.HomeBtn.TabIndex = 1;
            this.HomeBtn.Text = "      HOME";
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBtn.UseVisualStyleBackColor = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.pictureBox1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(178, 73);
            this.PanelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "http://127.0.0.1:8000/storage/product-images/logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 51);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HomeContent
            // 
            this.HomeContent.BackColor = System.Drawing.Color.White;
            this.HomeContent.Location = new System.Drawing.Point(270, 0);
            this.HomeContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HomeContent.Name = "HomeContent";
            this.HomeContent.Size = new System.Drawing.Size(1067, 744);
            this.HomeContent.TabIndex = 4;
            // 
            // ShopContent
            // 
            this.ShopContent.BackColor = System.Drawing.Color.White;
            this.ShopContent.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.ShopContent.Location = new System.Drawing.Point(239, 0);
            this.ShopContent.Name = "ShopContent";
            this.ShopContent.Size = new System.Drawing.Size(1058, 744);
            this.ShopContent.TabIndex = 2;
            // 
            // ContactContent
            // 
            this.ContactContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContactContent.Location = new System.Drawing.Point(239, 0);
            this.ContactContent.Name = "ContactContent";
            this.ContactContent.Size = new System.Drawing.Size(1058, 744);
            this.ContactContent.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.HomeContent);
            this.Controls.Add(this.ShopContent);
            this.Controls.Add(this.ContactContent);
            this.Controls.Add(this.PanelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "PETONA";
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton HomeBtn;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ContactBtn;
        private FontAwesome.Sharp.IconButton ShopBtn;
        private ShopContent ShopContent;
        private ContactContent ContactContent;
        private HomeContent HomeContent;
    }
}

