namespace KelimeBulmaOyunu
{
    partial class kelime_ekleme_penceresi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tablolari_listele_dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cikis_yap_label = new System.Windows.Forms.Label();
            this.kelime_ekle_label = new System.Windows.Forms.Label();
            this.kelime_sorusu_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kelime_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sil_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablolari_listele_dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablolari_listele_dgv
            // 
            this.tablolari_listele_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablolari_listele_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.tablolari_listele_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablolari_listele_dgv.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablolari_listele_dgv.DefaultCellStyle = dataGridViewCellStyle26;
            this.tablolari_listele_dgv.Location = new System.Drawing.Point(11, 12);
            this.tablolari_listele_dgv.Name = "tablolari_listele_dgv";
            this.tablolari_listele_dgv.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablolari_listele_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.tablolari_listele_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablolari_listele_dgv.Size = new System.Drawing.Size(746, 273);
            this.tablolari_listele_dgv.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cikis_yap_label);
            this.groupBox1.Controls.Add(this.kelime_ekle_label);
            this.groupBox1.Controls.Add(this.kelime_sorusu_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.kelime_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 148);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kelime İşlemleri";
            // 
            // cikis_yap_label
            // 
            this.cikis_yap_label.AutoSize = true;
            this.cikis_yap_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikis_yap_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikis_yap_label.Location = new System.Drawing.Point(516, 115);
            this.cikis_yap_label.Name = "cikis_yap_label";
            this.cikis_yap_label.Size = new System.Drawing.Size(96, 24);
            this.cikis_yap_label.TabIndex = 6;
            this.cikis_yap_label.Text = "Çıkış Yap";
            this.cikis_yap_label.Click += new System.EventHandler(this.cikis_yap_label_Click);
            this.cikis_yap_label.MouseLeave += new System.EventHandler(this.cikis_yap_label_MouseLeave);
            this.cikis_yap_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cikis_yap_label_MouseMove);
            // 
            // kelime_ekle_label
            // 
            this.kelime_ekle_label.AutoSize = true;
            this.kelime_ekle_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kelime_ekle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kelime_ekle_label.Location = new System.Drawing.Point(618, 115);
            this.kelime_ekle_label.Name = "kelime_ekle_label";
            this.kelime_ekle_label.Size = new System.Drawing.Size(121, 24);
            this.kelime_ekle_label.TabIndex = 4;
            this.kelime_ekle_label.Text = "Kelime Ekle";
            this.kelime_ekle_label.Click += new System.EventHandler(this.kelime_ekle_label_Click);
            this.kelime_ekle_label.MouseLeave += new System.EventHandler(this.kelime_ekle_label_MouseLeave);
            this.kelime_ekle_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kelime_ekle_label_MouseMove);
            // 
            // kelime_sorusu_tb
            // 
            this.kelime_sorusu_tb.Location = new System.Drawing.Point(155, 62);
            this.kelime_sorusu_tb.Multiline = true;
            this.kelime_sorusu_tb.Name = "kelime_sorusu_tb";
            this.kelime_sorusu_tb.Size = new System.Drawing.Size(584, 47);
            this.kelime_sorusu_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kelimenin Sorusu:";
            // 
            // kelime_tb
            // 
            this.kelime_tb.Location = new System.Drawing.Point(155, 32);
            this.kelime_tb.Name = "kelime_tb";
            this.kelime_tb.Size = new System.Drawing.Size(584, 24);
            this.kelime_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulunacak Kelime:";
            // 
            // sil_label
            // 
            this.sil_label.AutoSize = true;
            this.sil_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sil_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sil_label.Location = new System.Drawing.Point(576, 288);
            this.sil_label.Name = "sil_label";
            this.sil_label.Size = new System.Drawing.Size(175, 24);
            this.sil_label.TabIndex = 5;
            this.sil_label.Text = "Seçili Kelimeyi Sil";
            this.sil_label.Click += new System.EventHandler(this.sil_label_Click);
            this.sil_label.MouseLeave += new System.EventHandler(this.sil_label_MouseLeave);
            this.sil_label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sil_label_MouseMove);
            // 
            // kelime_ekleme_penceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sil_label);
            this.Controls.Add(this.tablolari_listele_dgv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "kelime_ekleme_penceresi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime İşlemleri";
            this.Load += new System.EventHandler(this.kelime_ekleme_penceresi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablolari_listele_dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablolari_listele_dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cikis_yap_label;
        private System.Windows.Forms.Label kelime_ekle_label;
        private System.Windows.Forms.TextBox kelime_sorusu_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kelime_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sil_label;
    }
}