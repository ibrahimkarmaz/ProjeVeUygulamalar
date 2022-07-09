namespace KelimeBulmaOyunu
{
    partial class kelime_oyun_ekrani
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cevap_btn = new System.Windows.Forms.Button();
            this.sorular_tb = new System.Windows.Forms.TextBox();
            this.sorularin_suresi_label = new System.Windows.Forms.Label();
            this.sorular_label = new System.Windows.Forms.Label();
            this.kelime_alttre = new System.Windows.Forms.Label();
            this.kelime_label_x = new System.Windows.Forms.Label();
            this.kacinci_soru_label = new System.Windows.Forms.Label();
            this.soru_icin_sure = new System.Windows.Forms.Timer(this.components);
            this.cevaplama_suresi = new System.Windows.Forms.Timer(this.components);
            this.toplam_puan_label = new System.Windows.Forms.Label();
            this.soru_puani_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.kelime_bul_gp = new System.Windows.Forms.GroupBox();
            this.cevaplama_suresi_label = new System.Windows.Forms.Label();
            this.kelime_bul_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kelime_bulma_tb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.kelime_bul_gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cevap_btn);
            this.groupBox1.Controls.Add(this.sorular_tb);
            this.groupBox1.Controls.Add(this.sorularin_suresi_label);
            this.groupBox1.Controls.Add(this.sorular_label);
            this.groupBox1.Controls.Add(this.kelime_alttre);
            this.groupBox1.Controls.Add(this.kelime_label_x);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(756, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kelime";
            // 
            // cevap_btn
            // 
            this.cevap_btn.Location = new System.Drawing.Point(562, 142);
            this.cevap_btn.Name = "cevap_btn";
            this.cevap_btn.Size = new System.Drawing.Size(189, 32);
            this.cevap_btn.TabIndex = 6;
            this.cevap_btn.Text = "Cevap Ver";
            this.cevap_btn.UseVisualStyleBackColor = true;
            this.cevap_btn.Click += new System.EventHandler(this.cevap_btn_Click);
            // 
            // sorular_tb
            // 
            this.sorular_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sorular_tb.Location = new System.Drawing.Point(63, 66);
            this.sorular_tb.Multiline = true;
            this.sorular_tb.Name = "sorular_tb";
            this.sorular_tb.Size = new System.Drawing.Size(688, 108);
            this.sorular_tb.TabIndex = 4;
            // 
            // sorularin_suresi_label
            // 
            this.sorularin_suresi_label.AutoSize = true;
            this.sorularin_suresi_label.Location = new System.Drawing.Point(640, 16);
            this.sorularin_suresi_label.Name = "sorularin_suresi_label";
            this.sorularin_suresi_label.Size = new System.Drawing.Size(53, 23);
            this.sorularin_suresi_label.TabIndex = 3;
            this.sorularin_suresi_label.Text = "Süre:";
            // 
            // sorular_label
            // 
            this.sorular_label.AutoSize = true;
            this.sorular_label.Location = new System.Drawing.Point(5, 66);
            this.sorular_label.Name = "sorular_label";
            this.sorular_label.Size = new System.Drawing.Size(52, 23);
            this.sorular_label.TabIndex = 2;
            this.sorular_label.Text = "Soru:";
            // 
            // kelime_alttre
            // 
            this.kelime_alttre.AutoSize = true;
            this.kelime_alttre.Location = new System.Drawing.Point(76, 25);
            this.kelime_alttre.Name = "kelime_alttre";
            this.kelime_alttre.Size = new System.Drawing.Size(139, 23);
            this.kelime_alttre.TabIndex = 1;
            this.kelime_alttre.Text = "_ _ _ _ _ _ _ _";
            // 
            // kelime_label_x
            // 
            this.kelime_label_x.AutoSize = true;
            this.kelime_label_x.Location = new System.Drawing.Point(5, 25);
            this.kelime_label_x.Name = "kelime_label_x";
            this.kelime_label_x.Size = new System.Drawing.Size(65, 23);
            this.kelime_label_x.TabIndex = 0;
            this.kelime_label_x.Text = "Kelime:";
            // 
            // kacinci_soru_label
            // 
            this.kacinci_soru_label.AutoSize = true;
            this.kacinci_soru_label.Location = new System.Drawing.Point(13, 189);
            this.kacinci_soru_label.Name = "kacinci_soru_label";
            this.kacinci_soru_label.Size = new System.Drawing.Size(110, 23);
            this.kacinci_soru_label.TabIndex = 3;
            this.kacinci_soru_label.Text = "Kaçıncı Soru:";
            // 
            // soru_icin_sure
            // 
            this.soru_icin_sure.Tick += new System.EventHandler(this.soru_icin_sure_Tick);
            // 
            // cevaplama_suresi
            // 
            this.cevaplama_suresi.Tick += new System.EventHandler(this.cevaplama_suresi_Tick);
            // 
            // toplam_puan_label
            // 
            this.toplam_puan_label.AutoSize = true;
            this.toplam_puan_label.Location = new System.Drawing.Point(569, 189);
            this.toplam_puan_label.Name = "toplam_puan_label";
            this.toplam_puan_label.Size = new System.Drawing.Size(111, 23);
            this.toplam_puan_label.TabIndex = 4;
            this.toplam_puan_label.Text = "Toplam Puan:";
            // 
            // soru_puani_label
            // 
            this.soru_puani_label.AutoSize = true;
            this.soru_puani_label.Location = new System.Drawing.Point(153, 189);
            this.soru_puani_label.Name = "soru_puani_label";
            this.soru_puani_label.Size = new System.Drawing.Size(97, 23);
            this.soru_puani_label.TabIndex = 5;
            this.soru_puani_label.Text = "Soru Puani:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Harf Ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kelime_bul_gp
            // 
            this.kelime_bul_gp.Controls.Add(this.cevaplama_suresi_label);
            this.kelime_bul_gp.Controls.Add(this.kelime_bul_button);
            this.kelime_bul_gp.Controls.Add(this.label1);
            this.kelime_bul_gp.Controls.Add(this.kelime_bulma_tb);
            this.kelime_bul_gp.Location = new System.Drawing.Point(356, 215);
            this.kelime_bul_gp.Name = "kelime_bul_gp";
            this.kelime_bul_gp.Size = new System.Drawing.Size(408, 101);
            this.kelime_bul_gp.TabIndex = 6;
            this.kelime_bul_gp.TabStop = false;
            this.kelime_bul_gp.Text = "Kelimeyi Bul";
            // 
            // cevaplama_suresi_label
            // 
            this.cevaplama_suresi_label.AutoSize = true;
            this.cevaplama_suresi_label.Location = new System.Drawing.Point(6, 63);
            this.cevaplama_suresi_label.Name = "cevaplama_suresi_label";
            this.cevaplama_suresi_label.Size = new System.Drawing.Size(53, 23);
            this.cevaplama_suresi_label.TabIndex = 7;
            this.cevaplama_suresi_label.Text = "Süre:";
            // 
            // kelime_bul_button
            // 
            this.kelime_bul_button.Location = new System.Drawing.Point(120, 58);
            this.kelime_bul_button.Name = "kelime_bul_button";
            this.kelime_bul_button.Size = new System.Drawing.Size(281, 32);
            this.kelime_bul_button.TabIndex = 7;
            this.kelime_bul_button.Text = "Kelime Bul";
            this.kelime_bul_button.UseVisualStyleBackColor = true;
            this.kelime_bul_button.Click += new System.EventHandler(this.kelime_bul_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kelimeyi Gir:";
            // 
            // kelime_bulma_tb
            // 
            this.kelime_bulma_tb.Location = new System.Drawing.Point(120, 23);
            this.kelime_bulma_tb.Name = "kelime_bulma_tb";
            this.kelime_bulma_tb.Size = new System.Drawing.Size(281, 30);
            this.kelime_bulma_tb.TabIndex = 0;
            // 
            // kelime_oyun_ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 325);
            this.Controls.Add(this.kelime_bul_gp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.soru_puani_label);
            this.Controls.Add(this.toplam_puan_label);
            this.Controls.Add(this.kacinci_soru_label);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "kelime_oyun_ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Bulma Penceresi";
            this.Load += new System.EventHandler(this.kelime_oyun_ekrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.kelime_bul_gp.ResumeLayout(false);
            this.kelime_bul_gp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kelime_alttre;
        private System.Windows.Forms.Label kelime_label_x;
        private System.Windows.Forms.Label sorular_label;
        private System.Windows.Forms.Label kacinci_soru_label;
        private System.Windows.Forms.Label sorularin_suresi_label;
        private System.Windows.Forms.Timer soru_icin_sure;
        private System.Windows.Forms.Timer cevaplama_suresi;
        private System.Windows.Forms.TextBox sorular_tb;
        private System.Windows.Forms.Label toplam_puan_label;
        private System.Windows.Forms.Label soru_puani_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cevap_btn;
        private System.Windows.Forms.GroupBox kelime_bul_gp;
        private System.Windows.Forms.Button kelime_bul_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kelime_bulma_tb;
        private System.Windows.Forms.Label cevaplama_suresi_label;
    }
}