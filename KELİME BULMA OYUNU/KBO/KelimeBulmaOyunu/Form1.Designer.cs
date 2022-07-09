namespace KelimeBulmaOyunu
{
    partial class Oyun_Giris_Penceresi
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
            this.components = new System.ComponentModel.Container();
            this.yarisma_numarasi_tb = new System.Windows.Forms.TextBox();
            this.yarismaci_adi_ve_soyadi_tb = new System.Windows.Forms.TextBox();
            this.Giris_penceresi_baslik = new System.Windows.Forms.Label();
            this.oyuna_basla_label = new System.Windows.Forms.Label();
            this.cikis_yap_label = new System.Windows.Forms.Label();
            this.yonetici_girisi_label = new System.Windows.Forms.Label();
            this.kurallar_checkbox = new System.Windows.Forms.CheckBox();
            this.zaman1 = new System.Windows.Forms.Timer(this.components);
            this.top_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yarisma_numarasi_tb
            // 
            this.yarisma_numarasi_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yarisma_numarasi_tb.Location = new System.Drawing.Point(76, 136);
            this.yarisma_numarasi_tb.Name = "yarisma_numarasi_tb";
            this.yarisma_numarasi_tb.ReadOnly = true;
            this.yarisma_numarasi_tb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yarisma_numarasi_tb.Size = new System.Drawing.Size(389, 28);
            this.yarisma_numarasi_tb.TabIndex = 2;
            this.yarisma_numarasi_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yarismaci_adi_ve_soyadi_tb
            // 
            this.yarismaci_adi_ve_soyadi_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yarismaci_adi_ve_soyadi_tb.Location = new System.Drawing.Point(76, 170);
            this.yarismaci_adi_ve_soyadi_tb.Name = "yarismaci_adi_ve_soyadi_tb";
            this.yarismaci_adi_ve_soyadi_tb.Size = new System.Drawing.Size(389, 28);
            this.yarismaci_adi_ve_soyadi_tb.TabIndex = 3;
            this.yarismaci_adi_ve_soyadi_tb.Text = "Yarışmacının Adı Soyadı";
            this.yarismaci_adi_ve_soyadi_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Giris_penceresi_baslik
            // 
            this.Giris_penceresi_baslik.AutoSize = true;
            this.Giris_penceresi_baslik.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giris_penceresi_baslik.Location = new System.Drawing.Point(68, 74);
            this.Giris_penceresi_baslik.Name = "Giris_penceresi_baslik";
            this.Giris_penceresi_baslik.Size = new System.Drawing.Size(404, 45);
            this.Giris_penceresi_baslik.TabIndex = 7;
            this.Giris_penceresi_baslik.Text = "KELİME BULMA OYUNU";
            // 
            // oyuna_basla_label
            // 
            this.oyuna_basla_label.AutoSize = true;
            this.oyuna_basla_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oyuna_basla_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyuna_basla_label.Location = new System.Drawing.Point(257, 246);
            this.oyuna_basla_label.Name = "oyuna_basla_label";
            this.oyuna_basla_label.Size = new System.Drawing.Size(155, 35);
            this.oyuna_basla_label.TabIndex = 8;
            this.oyuna_basla_label.Text = "Oyuna Başla";
            this.oyuna_basla_label.Click += new System.EventHandler(this.oyuna_basla_label_Click);
            this.oyuna_basla_label.MouseLeave += new System.EventHandler(this.oyuna_basla_label_MouseLeave);
            this.oyuna_basla_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.oyuna_basla_label_MouseMove);
            // 
            // cikis_yap_label
            // 
            this.cikis_yap_label.AutoSize = true;
            this.cikis_yap_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_yap_label.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_yap_label.Location = new System.Drawing.Point(131, 246);
            this.cikis_yap_label.Name = "cikis_yap_label";
            this.cikis_yap_label.Size = new System.Drawing.Size(120, 35);
            this.cikis_yap_label.TabIndex = 9;
            this.cikis_yap_label.Text = "Çıkış Yap";
            this.cikis_yap_label.Click += new System.EventHandler(this.cikis_yap_label_Click);
            this.cikis_yap_label.MouseLeave += new System.EventHandler(this.cikis_yap_label_MouseLeave);
            this.cikis_yap_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cikis_yap_label_MouseMove);
            // 
            // yonetici_girisi_label
            // 
            this.yonetici_girisi_label.AutoSize = true;
            this.yonetici_girisi_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yonetici_girisi_label.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetici_girisi_label.Location = new System.Drawing.Point(393, 9);
            this.yonetici_girisi_label.Name = "yonetici_girisi_label";
            this.yonetici_girisi_label.Size = new System.Drawing.Size(154, 30);
            this.yonetici_girisi_label.TabIndex = 10;
            this.yonetici_girisi_label.Text = "Yönetici Girişi";
            this.yonetici_girisi_label.Click += new System.EventHandler(this.yonetici_girisi_label_Click);
            this.yonetici_girisi_label.MouseLeave += new System.EventHandler(this.yonetici_girisi_label_MouseLeave);
            this.yonetici_girisi_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.yonetici_girisi_label_MouseMove);
            // 
            // kurallar_checkbox
            // 
            this.kurallar_checkbox.AutoSize = true;
            this.kurallar_checkbox.Location = new System.Drawing.Point(76, 208);
            this.kurallar_checkbox.Name = "kurallar_checkbox";
            this.kurallar_checkbox.Size = new System.Drawing.Size(209, 25);
            this.kurallar_checkbox.TabIndex = 11;
            this.kurallar_checkbox.Text = "Oyun kurallarını okudum.";
            this.kurallar_checkbox.UseVisualStyleBackColor = true;
            // 
            // zaman1
            // 
            this.zaman1.Tick += new System.EventHandler(this.zaman1_Tick);
            // 
            // top_label
            // 
            this.top_label.AutoSize = true;
            this.top_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.top_label.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.top_label.Location = new System.Drawing.Point(62, 298);
            this.top_label.Name = "top_label";
            this.top_label.Size = new System.Drawing.Size(423, 30);
            this.top_label.TabIndex = 12;
            this.top_label.Text = "En Başarılı Yarışmacılar Listesi(TOP 50)";
            this.top_label.Click += new System.EventHandler(this.top_label_Click);
            this.top_label.MouseLeave += new System.EventHandler(this.top_label_MouseLeave);
            this.top_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_label_MouseMove);
            // 
            // Oyun_Giris_Penceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 353);
            this.Controls.Add(this.top_label);
            this.Controls.Add(this.kurallar_checkbox);
            this.Controls.Add(this.yonetici_girisi_label);
            this.Controls.Add(this.cikis_yap_label);
            this.Controls.Add(this.oyuna_basla_label);
            this.Controls.Add(this.Giris_penceresi_baslik);
            this.Controls.Add(this.yarismaci_adi_ve_soyadi_tb);
            this.Controls.Add(this.yarisma_numarasi_tb);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Oyun_Giris_Penceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Bulma Oyunu";
            this.Load += new System.EventHandler(this.Oyun_Giris_Penceresi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yarisma_numarasi_tb;
        private System.Windows.Forms.TextBox yarismaci_adi_ve_soyadi_tb;
        private System.Windows.Forms.Label Giris_penceresi_baslik;
        private System.Windows.Forms.Label oyuna_basla_label;
        private System.Windows.Forms.Label cikis_yap_label;
        private System.Windows.Forms.Label yonetici_girisi_label;
        private System.Windows.Forms.CheckBox kurallar_checkbox;
        private System.Windows.Forms.Timer zaman1;
        private System.Windows.Forms.Label top_label;

    }
}

