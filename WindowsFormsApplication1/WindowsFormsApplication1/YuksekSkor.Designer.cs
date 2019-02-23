namespace WindowsFormsApplication1
{
    partial class YuksekSkor
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
            this.pnlskor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlskor
            // 
            this.pnlskor.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlskor.Location = new System.Drawing.Point(0, 0);
            this.pnlskor.Name = "pnlskor";
            this.pnlskor.Size = new System.Drawing.Size(415, 224);
            this.pnlskor.TabIndex = 0;
            // 
            // YuksekSkor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(416, 224);
            this.Controls.Add(this.pnlskor);
            this.Name = "YuksekSkor";
            this.Text = "YuksekSkor";
            this.Load += new System.EventHandler(this.YuksekSkor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlskor;
    }
}