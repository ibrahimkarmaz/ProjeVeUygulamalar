namespace KelimeBulmaOyunu
{
    partial class Yonetici_Girisi_Penceresi
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
            this.cikis_yap_label = new System.Windows.Forms.Label();
            this.giris_yap_label = new System.Windows.Forms.Label();
            this.parola_tb = new System.Windows.Forms.TextBox();
            this.yonetici_adi_tb = new System.Windows.Forms.TextBox();
            this.geri_don_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cikis_yap_label
            // 
            this.cikis_yap_label.AutoSize = true;
            this.cikis_yap_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_yap_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_yap_label.Location = new System.Drawing.Point(12, 98);
            this.cikis_yap_label.Name = "cikis_yap_label";
            this.cikis_yap_label.Size = new System.Drawing.Size(104, 25);
            this.cikis_yap_label.TabIndex = 15;
            this.cikis_yap_label.Text = "Çıkış Yap";
            this.cikis_yap_label.Click += new System.EventHandler(this.cikis_yap_label_Click);
            this.cikis_yap_label.MouseLeave += new System.EventHandler(this.cikis_yap_label_MouseLeave);
            this.cikis_yap_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cikis_yap_label_MouseMove);
            // 
            // giris_yap_label
            // 
            this.giris_yap_label.AutoSize = true;
            this.giris_yap_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_yap_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_yap_label.Location = new System.Drawing.Point(172, 98);
            this.giris_yap_label.Name = "giris_yap_label";
            this.giris_yap_label.Size = new System.Drawing.Size(101, 25);
            this.giris_yap_label.TabIndex = 14;
            this.giris_yap_label.Text = "Giriş Yap";
            this.giris_yap_label.Click += new System.EventHandler(this.giris_yap_label_Click);
            this.giris_yap_label.MouseLeave += new System.EventHandler(this.giris_yap_label_MouseLeave);
            this.giris_yap_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.giris_yap_label_MouseMove);
            // 
            // parola_tb
            // 
            this.parola_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.parola_tb.Location = new System.Drawing.Point(11, 66);
            this.parola_tb.Name = "parola_tb";
            this.parola_tb.Size = new System.Drawing.Size(263, 24);
            this.parola_tb.TabIndex = 13;
            this.parola_tb.Text = "Parola";
            this.parola_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.parola_tb.UseSystemPasswordChar = true;
            // 
            // yonetici_adi_tb
            // 
            this.yonetici_adi_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yonetici_adi_tb.Location = new System.Drawing.Point(11, 37);
            this.yonetici_adi_tb.Name = "yonetici_adi_tb";
            this.yonetici_adi_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yonetici_adi_tb.Size = new System.Drawing.Size(263, 24);
            this.yonetici_adi_tb.TabIndex = 12;
            this.yonetici_adi_tb.Text = "Yönetici Adı";
            this.yonetici_adi_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // geri_don_label
            // 
            this.geri_don_label.AutoSize = true;
            this.geri_don_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geri_don_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geri_don_label.Location = new System.Drawing.Point(27, 131);
            this.geri_don_label.Name = "geri_don_label";
            this.geri_don_label.Size = new System.Drawing.Size(227, 25);
            this.geri_don_label.TabIndex = 16;
            this.geri_don_label.Text = "Giriş Penceresine Dön";
            this.geri_don_label.Click += new System.EventHandler(this.geri_don_label_Click);
            this.geri_don_label.MouseLeave += new System.EventHandler(this.geri_don_label_MouseLeave);
            this.geri_don_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.geri_don_label_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Yönetici Girişi";
            // 
            // Yonetici_Girisi_Penceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 169);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geri_don_label);
            this.Controls.Add(this.cikis_yap_label);
            this.Controls.Add(this.giris_yap_label);
            this.Controls.Add(this.parola_tb);
            this.Controls.Add(this.yonetici_adi_tb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Yonetici_Girisi_Penceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Girişi";
            this.Load += new System.EventHandler(this.Yonetici_Girisi_Penceresi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cikis_yap_label;
        private System.Windows.Forms.Label giris_yap_label;
        private System.Windows.Forms.TextBox parola_tb;
        private System.Windows.Forms.TextBox yonetici_adi_tb;
        private System.Windows.Forms.Label geri_don_label;
        private System.Windows.Forms.Label label1;
    }
}