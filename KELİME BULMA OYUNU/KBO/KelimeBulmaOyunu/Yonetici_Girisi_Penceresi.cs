using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KelimeBulmaOyunu
{
    public partial class Yonetici_Girisi_Penceresi : Form
    {
        public Yonetici_Girisi_Penceresi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Oyun_Giris_Penceresi.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        SqlDataReader oku;//VERİ ÇEKİLME İŞLEMİ VARSA KULLANILAN KOMUTLERDEN BİRİSİ
        private void Yonetici_Girisi_Penceresi_Load(object sender, EventArgs e)
        {

        }

        private void giris_yap_label_Click(object sender, EventArgs e)
        {
            giris_yap_fk();
        }

        private void giris_yap_fk()//GİRİŞ FOKSİYONU
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("select * from giris_tb where kullanici='" + yonetici_adi_tb.Text + "' and sifre='" + parola_tb.Text + "'", baglanti);//KULLANICI ADI PAROLA ARANAN KOMUT
                oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                if (oku.Read())//EĞER VERİLER OKUNUYORSA DOĞRU BLOĞUNA GİRER.
                {
                    //KELİME EKLEME GÜNCELLEME VE SİLME PENCERESİNE GİDER.
                    kelime_ekleme_penceresi KEP = new kelime_ekleme_penceresi();
                    KEP.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("KULLANICI ADI VEYA PAROLA YANLIŞTIR", "GİRİŞ HATASI", MessageBoxButtons.OK, MessageBoxIcon.Error);//EĞER GİRİŞ YAPILAMADI İSE NEDENLERINI PENCEREDE GÖSTERME
                }
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            }
            catch (Exception HATA)
            {
                baglanti.Close();//EĞER HATA VERİRSE BAĞLANTIYI KAPATMA NEDENİ:BAĞLI YERE TEKRAR BAĞLANAMASSIN.
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.//HATA BİLGİSİ GÖSTERME
            }
        }

        private void cikis_yap_label_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ÇIKIŞ YAPILSIN MI ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void geri_don_label_Click(object sender, EventArgs e)
        {
            Oyun_Giris_Penceresi OGP = new Oyun_Giris_Penceresi();
            OGP.Show();
            this.Hide();
        }

        private void giris_yap_label_MouseMove(object sender, MouseEventArgs e)
        {
            giris_yap_label.ForeColor = Color.Red;
        }

        private void giris_yap_label_MouseLeave(object sender, EventArgs e)
        {
            giris_yap_label.ForeColor = Color.Black;
        }

        private void cikis_yap_label_MouseMove(object sender, MouseEventArgs e)
        {
            cikis_yap_label.ForeColor = Color.Red;
        }

        private void cikis_yap_label_MouseLeave(object sender, EventArgs e)
        {
            cikis_yap_label.ForeColor = Color.Black;
        }

        private void geri_don_label_MouseMove(object sender, MouseEventArgs e)
        {
            geri_don_label.ForeColor = Color.Red;
        }

        private void geri_don_label_MouseLeave(object sender, EventArgs e)
        {
            geri_don_label.ForeColor = Color.Black;
        }
    }
}
