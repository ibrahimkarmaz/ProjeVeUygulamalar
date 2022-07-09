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
    public partial class kelime_ekleme_penceresi : Form
    {
        public kelime_ekleme_penceresi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Oyun_Giris_Penceresi.global_baglanti_adresi);
        SqlDataAdapter Komutlar;//TABLOLARIN ÇEKİLMESİNDE KULLANILAN KOMUT
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        DataSet veriseti = new DataSet();//ÇEKİLEN TABLOLARI SAKLAMAK İÇİN GEREK KOMUT
        private void kelime_ekleme_penceresi_Load(object sender, EventArgs e)
        {
            kelime_listesini_getir();
            kelime_listesini_duzenle();
            kelime_tb.MaxLength = 14;
        }
        private void kelime_listesini_getir()//KELİME BİLGİLERİNİ GETİRME
        {
            veriseti.Clear();//TABLOLARI SİLER 
            baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
            Komutlar = new SqlDataAdapter("select kelime,kelimenin_sorusu from kelime_tablosu", baglanti);//KELİME BİLGİLERİ
            Komutlar.Fill(veriseti, "kelime_tablosu");
            baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            tablolari_listele_dgv.DataSource = veriseti.Tables["kelime_tablosu"];//PERSONEL TABLOSUNDA GÖSTERME

        }
        private void kelime_listesini_duzenle()//ALANLARI DÜZENLEME
        {
            tablolari_listele_dgv.Columns["kelime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["kelimenin_sorusu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ


            tablolari_listele_dgv.Columns["kelime"].HeaderText = "KELİME";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["kelimenin_sorusu"].HeaderText = "KELİMENİN SORUSU";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ        
        }

        private void sil_label_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() != "")
                {
                    if (MessageBox.Show("SEÇİLEN KELİME:" + tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() + " SİLİNSİN MI ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cikar();
                    }
                }
                else
                {
                    MessageBox.Show("KELİEME SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("KELİME SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void cikar()//KELİME ÇIKARMA KOMUTLARI
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("delete from kelime_tablosu where kelime='" + tablolari_listele_dgv.CurrentRow.Cells[0].Value.ToString() + "' and kelimenin_sorusu='" + tablolari_listele_dgv.CurrentRow.Cells[1].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("KELİME SİLİNDİ.", "KELİME İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kelime_listesini_getir();
            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }
        //30 sniye 3 hrf
        private void kelime_ekle_label_Click(object sender, EventArgs e)
        {
            if (kelime_tb.TextLength>=4)
            {
                if (kelime_sorusu_tb.Text!="")
                {
                    Ekle();
                }
                else
                {
                    MessageBox.Show("KELİME İÇİN SORU GİRİLMELİ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("KELİME EN AZ 4, EN FAZLA 14 HARF İÇERMELİ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Ekle()//KELİME EKLEME KOMUTLARI
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("insert into kelime_tablosu values('"+kelime_tb.Text+"','"+kelime_sorusu_tb.Text+"')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("KELİME EKLENDI.", "KELİME İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kelime_listesini_getir();
                kelime_sorusu_tb.Text = kelime_tb.Text = "";
            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }

        private void cikis_yap_label_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ÇIKIŞ YAPILSIN MI ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void sil_label_MouseMove(object sender, MouseEventArgs e)
        {
            sil_label.ForeColor = Color.Red;
        }

        private void sil_label_MouseLeave(object sender, EventArgs e)
        {
            sil_label.ForeColor = Color.Black;
        }

        private void kelime_ekle_label_MouseMove(object sender, MouseEventArgs e)
        {
            kelime_ekle_label.ForeColor = Color.Red;
        }

        private void kelime_ekle_label_MouseLeave(object sender, EventArgs e)
        {
            kelime_ekle_label.ForeColor = Color.Black;
        }

        private void cikis_yap_label_MouseMove(object sender, MouseEventArgs e)
        {
            cikis_yap_label.ForeColor = Color.Red;
        }

        private void cikis_yap_label_MouseLeave(object sender, EventArgs e)
        {
            cikis_yap_label.ForeColor = Color.Black;
        }
    }
}
