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
            this.SuspendLayout();
            // 
            // ShopFlowPanel
            // 
            this.ShopFlowPanel.BackColor = System.Drawing.Color.Green;
            this.ShopFlowPanel.Location = new System.Drawing.Point(3, 111);
            this.ShopFlowPanel.Name = "ShopFlowPanel";
            this.ShopFlowPanel.Size = new System.Drawing.Size(1550, 800);
            this.ShopFlowPanel.TabIndex = 9;
            // 
            // ScrollBar
            // 
            this.ScrollBar.Location = new System.Drawing.Point(1556, 111);
            this.ScrollBar.Name = "ScrollBar";
            this.ScrollBar.Size = new System.Drawing.Size(26, 689);
            this.ScrollBar.TabIndex = 10;
            this.ScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBar_Scroll_1);
            // 
            // ShopContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScrollBar);
            this.Controls.Add(this.ShopFlowPanel);
            this.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.Name = "ShopContent";
            this.Size = new System.Drawing.Size(1920, 1080);
            this.Load += new System.EventHandler(this.ShopContent_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ShopFlowPanel;
        private System.Windows.Forms.VScrollBar ScrollBar;
    }
}
