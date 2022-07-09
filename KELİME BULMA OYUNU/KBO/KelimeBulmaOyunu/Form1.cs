using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace KelimeBulmaOyunu
{
    public partial class Oyun_Giris_Penceresi : Form
    {
        public Oyun_Giris_Penceresi()
        {
            InitializeComponent();
        }
        string baslik_bilgisi = "";
        public static string global_baglanti_adresi = @"server=DESKTOP-5DGSRBQ;database=KBO;Trusted_Connection=yes";
        private void Oyun_Giris_Penceresi_Load(object sender, EventArgs e)
        {
            zaman1.Interval = 250;
            baslik_bilgisi = Giris_penceresi_baslik.Text;
            Giris_penceresi_baslik.Text = "";
            zaman1.Start();

            for (int i = 0; i < 6; i++)
            {
                yarisma_numarasi_tb.Text += rasgele_renk_olusturma.Next(0, 10);
            }
        }
        int sayac = 0;
        Random rasgele_renk_olusturma = new Random();
        private void zaman1_Tick(object sender, EventArgs e)
        {
            if (baslik_bilgisi.Length>sayac)
            {
                Giris_penceresi_baslik.Text += baslik_bilgisi[sayac].ToString();
                sayac++;
                Giris_penceresi_baslik.ForeColor = Color.FromArgb(rasgele_renk_olusturma.Next(0, 256), rasgele_renk_olusturma.Next(0, 256), rasgele_renk_olusturma.Next(0, 256));
            }
            else if ((baslik_bilgisi.Length+30)>sayac)
            {
                sayac++;
                Giris_penceresi_baslik.ForeColor = Color.FromArgb(rasgele_renk_olusturma.Next(0, 256), rasgele_renk_olusturma.Next(0, 256), rasgele_renk_olusturma.Next(0, 256));
            }
            else
            {
                Giris_penceresi_baslik.Text = "";
                sayac = 0;
            }
        }

        private void yonetici_girisi_label_Click(object sender, EventArgs e)
        {
            Yonetici_Girisi_Penceresi YGP = new Yonetici_Girisi_Penceresi();
            YGP.Show();
            this.Hide();
        }

        private void yonetici_girisi_label_MouseMove(object sender, MouseEventArgs e)
        {
            yonetici_girisi_label.ForeColor = Color.Red;
        }

        private void yonetici_girisi_label_MouseLeave(object sender, EventArgs e)
        {
            yonetici_girisi_label.ForeColor = Color.Black;
        }
        public static string kayit_kodu;
        public static string adi_soyadi;
        private void oyuna_basla_label_Click(object sender, EventArgs e)
        {
            kayit_kodu = yarisma_numarasi_tb.Text;
            adi_soyadi = yarismaci_adi_ve_soyadi_tb.Text;
            kelime_oyun_ekrani KOP = new kelime_oyun_ekrani();
            KOP.Show();
            this.Hide();
        }

        private void cikis_yap_label_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ÇIKIŞ YAPILSIN MI ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cikis_yap_label_MouseMove(object sender, MouseEventArgs e)
        {
            cikis_yap_label.ForeColor = Color.Red;
        }

        private void cikis_yap_label_MouseLeave(object sender, EventArgs e)
        {
            cikis_yap_label.ForeColor = Color.Black;
        }

        private void oyuna_basla_label_MouseMove(object sender, MouseEventArgs e)
        {
            oyuna_basla_label.ForeColor = Color.Red;
        }

        private void oyuna_basla_label_MouseLeave(object sender, EventArgs e)
        {
            oyuna_basla_label.ForeColor = Color.Black;
        }

        private void top_label_Click(object sender, EventArgs e)
        {
            top_x_penceresi TXP = new top_x_penceresi();
            TXP.ShowDialog();
        }

        private void top_label_MouseMove(object sender, MouseEventArgs e)
        {
            top_label.ForeColor = Color.Red;
        }

        private void top_label_MouseLeave(object sender, EventArgs e)
        {
            top_label.ForeColor = Color.Black;
        }
    }
}
