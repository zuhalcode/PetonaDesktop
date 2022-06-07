namespace PetonaDesktop
{
    partial class InputProdukContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KembaliButton = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.UploadBtn = new System.Windows.Forms.Panel();
            this.DataProducts = new System.Windows.Forms.DataGridView();
            this.AddItemBtn = new FontAwesome.Sharp.IconButton();
            this.PicUpload = new System.Windows.Forms.Button();
            this.ProductPic = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.TextBox();
            this.ProductAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.UploadBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).BeginInit();
            this.SuspendLayout();
            // 
            // KembaliButton
            // 
            this.KembaliButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(210)))), ((int)(((byte)(120)))));
            this.KembaliButton.FlatAppearance.BorderSize = 0;
            this.KembaliButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KembaliButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.KembaliButton.ForeColor = System.Drawing.Color.White;
            this.KembaliButton.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.KembaliButton.IconColor = System.Drawing.Color.White;
            this.KembaliButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.KembaliButton.IconSize = 40;
            this.KembaliButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.KembaliButton.Location = new System.Drawing.Point(0, 0);
            this.KembaliButton.Name = "KembaliButton";
            this.KembaliButton.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.KembaliButton.Size = new System.Drawing.Size(197, 55);
            this.KembaliButton.TabIndex = 5;
            this.KembaliButton.Text = "   Kembali";
            this.KembaliButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KembaliButton.UseVisualStyleBackColor = false;
            this.KembaliButton.Click += new System.EventHandler(this.KembaliButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.Location = new System.Drawing.Point(379, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 69);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tambah Barang Baru";
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(120)))), ((int)(((byte)(250)))));
            this.UploadBtn.Controls.Add(this.DataProducts);
            this.UploadBtn.Controls.Add(this.AddItemBtn);
            this.UploadBtn.Controls.Add(this.PicUpload);
            this.UploadBtn.Controls.Add(this.ProductPic);
            this.UploadBtn.Controls.Add(this.label6);
            this.UploadBtn.Controls.Add(this.label5);
            this.UploadBtn.Controls.Add(this.label4);
            this.UploadBtn.Controls.Add(this.ProductPrice);
            this.UploadBtn.Controls.Add(this.ProductAmount);
            this.UploadBtn.Controls.Add(this.label2);
            this.UploadBtn.Controls.Add(this.ProductName);
            this.UploadBtn.Location = new System.Drawing.Point(3, 87);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(1367, 692);
            this.UploadBtn.TabIndex = 7;
            // 
            // DataProducts
            // 
            this.DataProducts.AllowUserToAddRows = false;
            this.DataProducts.AllowUserToDeleteRows = false;
            this.DataProducts.AllowUserToResizeColumns = false;
            this.DataProducts.AllowUserToResizeRows = false;
            this.DataProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataProducts.BackgroundColor = System.Drawing.Color.White;
            this.DataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataProducts.GridColor = System.Drawing.Color.White;
            this.DataProducts.Location = new System.Drawing.Point(332, 0);
            this.DataProducts.MultiSelect = false;
            this.DataProducts.Name = "DataProducts";
            this.DataProducts.RowHeadersVisible = false;
            this.DataProducts.RowHeadersWidth = 62;
            this.DataProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataProducts.RowTemplate.Height = 28;
            this.DataProducts.ShowEditingIcon = false;
            this.DataProducts.Size = new System.Drawing.Size(1035, 692);
            this.DataProducts.TabIndex = 15;
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(210)))), ((int)(((byte)(120)))));
            this.AddItemBtn.FlatAppearance.BorderSize = 0;
            this.AddItemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.AddItemBtn.ForeColor = System.Drawing.Color.White;
            this.AddItemBtn.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.AddItemBtn.IconColor = System.Drawing.Color.White;
            this.AddItemBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddItemBtn.IconSize = 40;
            this.AddItemBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddItemBtn.Location = new System.Drawing.Point(24, 605);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.AddItemBtn.Size = new System.Drawing.Size(283, 55);
            this.AddItemBtn.TabIndex = 8;
            this.AddItemBtn.Text = "Tambah barang";
            this.AddItemBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddItemBtn.UseVisualStyleBackColor = false;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // PicUpload
            // 
            this.PicUpload.Location = new System.Drawing.Point(89, 524);
            this.PicUpload.Name = "PicUpload";
            this.PicUpload.Size = new System.Drawing.Size(157, 43);
            this.PicUpload.TabIndex = 14;
            this.PicUpload.Text = "Upload Gambar";
            this.PicUpload.UseVisualStyleBackColor = true;
            this.PicUpload.Click += new System.EventHandler(this.PicUpload_Click);
            // 
            // ProductPic
            // 
            this.ProductPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductPic.Location = new System.Drawing.Point(24, 335);
            this.ProductPic.Name = "ProductPic";
            this.ProductPic.Size = new System.Drawing.Size(283, 183);
            this.ProductPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPic.TabIndex = 13;
            this.ProductPic.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gambar Produk";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Stok Barang";
            // 
            // ProductPrice
            // 
            this.ProductPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ProductPrice.Location = new System.Drawing.Point(26, 238);
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(281, 41);
            this.ProductPrice.TabIndex = 11;
            // 
            // ProductAmount
            // 
            this.ProductAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ProductAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ProductAmount.Location = new System.Drawing.Point(24, 148);
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.Size = new System.Drawing.Size(281, 41);
            this.ProductAmount.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama Produk";
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ProductName.Location = new System.Drawing.Point(25, 53);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(281, 41);
            this.ProductName.TabIndex = 9;
            // 
            // InputProdukContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KembaliButton);
            this.Name = "InputProdukContent";
            this.Size = new System.Drawing.Size(1600, 1145);
            this.Load += new System.EventHandler(this.InputProdukContent_Load);
            this.UploadBtn.ResumeLayout(false);
            this.UploadBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton KembaliButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel UploadBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductPrice;
        private System.Windows.Forms.TextBox ProductAmount;
        private System.Windows.Forms.Button PicUpload;
        private System.Windows.Forms.PictureBox ProductPic;
        private FontAwesome.Sharp.IconButton AddItemBtn;
        private System.Windows.Forms.DataGridView DataProducts;
    }
}
