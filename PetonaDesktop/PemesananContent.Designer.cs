namespace PetonaDesktop
{
    partial class PemesananContent
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
            // PemesananContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.KembaliButton);
            this.Name = "PemesananContent";
            this.Size = new System.Drawing.Size(1343, 641);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton KembaliButton;
    }
}
