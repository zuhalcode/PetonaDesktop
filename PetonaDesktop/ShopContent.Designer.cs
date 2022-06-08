namespace PetonaDesktop
{
    partial class ShopContent
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
            this.ShopFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ScrollBar = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RefreshBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // ShopFlowPanel
            // 
            this.ShopFlowPanel.BackColor = System.Drawing.Color.White;
            this.ShopFlowPanel.Location = new System.Drawing.Point(1, 74);
            this.ShopFlowPanel.Name = "ShopFlowPanel";
            this.ShopFlowPanel.Size = new System.Drawing.Size(1600, 813);
            this.ShopFlowPanel.TabIndex = 9;
            // 
            // ScrollBar
            // 
            this.ScrollBar.Location = new System.Drawing.Point(1604, 74);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(26, 817);
            this.ScrollBar.TabIndex = 10;
            this.ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 58);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tampilkan Semua Produk";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 3);
            this.panel1.TabIndex = 12;
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
            this.RefreshBtn.Location = new System.Drawing.Point(607, 3);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.RefreshBtn.Size = new System.Drawing.Size(51, 50);
            this.RefreshBtn.TabIndex = 13;
            this.RefreshBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ShopContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.ShopFlowPanel);
            this.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.Name = "ShopContent";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.ShopContent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ShopFlowPanel;
        private System.Windows.Forms.VScrollBar ScrollBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton RefreshBtn;
    }
}
