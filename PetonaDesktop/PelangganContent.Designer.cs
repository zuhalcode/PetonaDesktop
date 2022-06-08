namespace PetonaDesktop
{
    partial class PelangganContent
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
            this.DataCustomers = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataCustomers)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.KembaliButton.TabIndex = 4;
            this.KembaliButton.Text = "   Kembali";
            this.KembaliButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.KembaliButton.UseVisualStyleBackColor = false;
            this.KembaliButton.Click += new System.EventHandler(this.KembaliButton_Click);
            // 
            // DataCustomers
            // 
            this.DataCustomers.AllowUserToAddRows = false;
            this.DataCustomers.AllowUserToDeleteRows = false;
            this.DataCustomers.AllowUserToResizeColumns = false;
            this.DataCustomers.AllowUserToResizeRows = false;
            this.DataCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DataCustomers.BackgroundColor = System.Drawing.Color.White;
            this.DataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCustomers.GridColor = System.Drawing.Color.White;
            this.DataCustomers.Location = new System.Drawing.Point(0, 129);
            this.DataCustomers.MultiSelect = false;
            this.DataCustomers.Name = "DataCustomers";
            this.DataCustomers.RowHeadersVisible = false;
            this.DataCustomers.RowHeadersWidth = 62;
            this.DataCustomers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataCustomers.RowTemplate.Height = 28;
            this.DataCustomers.ShowEditingIcon = false;
            this.DataCustomers.Size = new System.Drawing.Size(1089, 537);
            this.DataCustomers.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.RefreshBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 53);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pelanggan";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(210)))), ((int)(((byte)(120)))));
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.RefreshBtn.ForeColor = System.Drawing.Color.White;
            this.RefreshBtn.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.RefreshBtn.IconColor = System.Drawing.Color.White;
            this.RefreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.RefreshBtn.IconSize = 40;
            this.RefreshBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RefreshBtn.Location = new System.Drawing.Point(644, 2);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.RefreshBtn.Size = new System.Drawing.Size(51, 50);
            this.RefreshBtn.TabIndex = 18;
            this.RefreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // PelangganContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataCustomers);
            this.Controls.Add(this.KembaliButton);
            this.Name = "PelangganContent";
            this.Size = new System.Drawing.Size(1089, 666);
            this.Load += new System.EventHandler(this.PelangganContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataCustomers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton KembaliButton;
        private System.Windows.Forms.DataGridView DataCustomers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton RefreshBtn;
    }
}
