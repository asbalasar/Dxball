namespace WindowsFormsApplication1
{
    partial class KayıtEkranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblgızlı = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblskor = new System.Windows.Forms.Label();
            this.btnvazgec = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEBRİKLER YÜKSEK BİR SKOR YAPTINIZ.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "LÜTFEN ADINIZI GİRİN.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lblgızlı);
            this.panel1.Controls.Add(this.txtad);
            this.panel1.Controls.Add(this.lblskor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 225);
            this.panel1.TabIndex = 2;
            // 
            // lblgızlı
            // 
            this.lblgızlı.AutoSize = true;
            this.lblgızlı.Location = new System.Drawing.Point(401, 127);
            this.lblgızlı.Name = "lblgızlı";
            this.lblgızlı.Size = new System.Drawing.Size(35, 13);
            this.lblgızlı.TabIndex = 5;
            this.lblgızlı.Text = "label3";
            this.lblgızlı.Visible = false;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(129, 154);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(176, 30);
            this.txtad.TabIndex = 3;
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblskor.Location = new System.Drawing.Point(186, 115);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(65, 25);
            this.lblskor.TabIndex = 2;
            this.lblskor.Text = "label3";
            // 
            // btnvazgec
            // 
            this.btnvazgec.Location = new System.Drawing.Point(305, 243);
            this.btnvazgec.Name = "btnvazgec";
            this.btnvazgec.Size = new System.Drawing.Size(75, 23);
            this.btnvazgec.TabIndex = 3;
            this.btnvazgec.Text = "Vazgeç";
            this.btnvazgec.UseVisualStyleBackColor = true;
            this.btnvazgec.Click += new System.EventHandler(this.btnvazgec_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(393, 243);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // KayıtEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 278);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.btnvazgec);
            this.Controls.Add(this.panel1);
            this.Name = "KayıtEkranı";
            this.Text = "KayıtEkranı";
            this.Load += new System.EventHandler(this.KayıtEkranı_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Button btnvazgec;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label lblgızlı;
    }
}