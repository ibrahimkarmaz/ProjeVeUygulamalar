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
using System.Collections;

namespace KelimeBulmaOyunu
{
    public partial class kelime_oyun_ekrani : Form
    {
        public kelime_oyun_ekrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Oyun_Giris_Penceresi.global_baglanti_adresi);//VERİTABANINA BAĞLANTI ADRESİ
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        SqlDataReader oku;//VERİ ÇEKİLME İŞLEMİ VARSA KULLANILAN KOMUTLERDEN BİRİSİ
        ArrayList harf4sorular = new ArrayList();
        ArrayList harf5sorular = new ArrayList();
        ArrayList harf6sorular = new ArrayList();
        ArrayList harf7sorular = new ArrayList();
        ArrayList harf8sorular = new ArrayList();
        ArrayList harf9sorular = new ArrayList();
        ArrayList harf10sorular = new ArrayList();

        ArrayList harf4cevaplar = new ArrayList();
        ArrayList harf5cevaplar = new ArrayList();
        ArrayList harf6cevaplar = new ArrayList();
        ArrayList harf7cevaplar = new ArrayList();
        ArrayList harf8cevaplar = new ArrayList();
        ArrayList harf9cevaplar = new ArrayList();
        ArrayList harf10cevaplar = new ArrayList();
        byte soru_seviyesi = 0;//2 tane 4 2 tane 5 .... gibi ilerler.
        int secilen_index;
        int soru_sure = (60 * 4);
        byte soru_sure_dk = 4;
        int puan = 0;
        int soru_puani;

        string var_olan_kelime;
        byte kalan_harf_hakki;
        private void kelime_oyun_ekrani_Load(object sender, EventArgs e)
        {
            kelime_islem_foksiyon();
            soru_icin_sure.Interval = 1000;
            soru_icin_sure.Start();
            soru_getir_fk();
            kelime_bul_gp.Enabled = false;
        }
        Random soru_sec = new Random();
        ArrayList gozuken_harfler = new ArrayList();
        private void soru_getir_fk()
        {
            soru_seviyesi++;
            if (soru_seviyesi == 1 || soru_seviyesi == 2)
            {
                kalan_harf_hakki = 3;
            tekrar_sec:
                int gecici_index_secimi = soru_sec.Next(0, harf4sorular.Count);
                if (secilen_index == gecici_index_secimi)
                {
                    goto tekrar_sec;
                }
                else
                {
                    secilen_index = gecici_index_secimi;
                }
                sorular_tb.Text = harf4sorular[secilen_index].ToString();
                soru_puani = harf4cevaplar[secilen_index].ToString().Length * 100;//HARF BAŞINA 100 PUAN
                var_olan_kelime = harf4cevaplar[secilen_index].ToString();
                kelime_alttre.Text = "";
                for (int i = 0; i < harf4cevaplar[secilen_index].ToString().Length; i++)
                {
                    gozuken_harfler.Add("_");
                }

                for (int i = 0; i < harf4cevaplar[secilen_index].ToString().Length; i++)
                {
                    kelime_alttre.Text += gozuken_harfler[i].ToString();
                    if (harf4cevaplar[secilen_index].ToString().Length - 1 > i)
                    {
                        kelime_alttre.Text += " ";
                    }
                }
                kacinci_soru_label.Text = "Kaçıncı Soru:" + soru_seviyesi;
                toplam_puan_label.Text = "Toplam Puan:" + puan;
                soru_puani_label.Text = "Soru Puani:" + soru_puani;
               
            }
            else if (soru_seviyesi == 3 || soru_seviyesi == 4)
            {
                kalan_harf_hakki = 4;
            tekrar_sec:
                int gecici_index_secimi = soru_sec.Next(0, harf5sorular.Count);
                if (secilen_index == gecici_index_secimi)
                {
                    goto tekrar_sec;
                }
                else
                {
                    secilen_index = gecici_index_secimi;
                }
                sorular_tb.Text = harf5sorular[secilen_index].ToString();
                soru_puani = harf5cevaplar[secilen_index].ToString().Length * 100;//HARF BAŞINA 100 PUAN
                var_olan_kelime = harf5cevaplar[secilen_index].ToString();
                kelime_alttre.Text = "";
                for (int i = 0; i < harf5cevaplar[secilen_index].ToString().Length; i++)
                {
                    gozuken_harfler.Add("_");
                }

                for (int i = 0; i < harf5cevaplar[secilen_index].ToString().Length; i++)
                {
                    kelime_alttre.Text += gozuken_harfler[i].ToString();
                    if (harf5cevaplar[secilen_index].ToString().Length - 1 > i)
                    {
                        kelime_alttre.Text += " ";
                    }
                }
                kacinci_soru_label.Text = "Kaçıncı Soru:" + soru_seviyesi;
                toplam_puan_label.Text = "Toplam Puan:" + puan;
                soru_puani_label.Text = "Soru Puani:" + soru_puani;
            }
            else if (soru_seviyesi == 5 || soru_seviyesi == 6)
            {
                kalan_harf_hakki = 5;
            tekrar_sec:
                int gecici_index_secimi = soru_sec.Next(0, harf6sorular.Count);
                if (secilen_index == gecici_index_secimi)
                {
                    goto tekrar_sec;
                }
                else
                {
                    secilen_index = gecici_index_secimi;
                }
                sorular_tb.Text = harf6sorular[secilen_index].ToString();
                soru_puani = harf6cevaplar[secilen_index].ToString().Length * 100;//HARF BAŞINA 100 PUAN
                var_olan_kelime = harf6cevaplar[secilen_index].ToString();
                kelime_alttre.Text = "";
                for (int i = 0; i < harf6cevaplar[secilen_index].ToString().Length; i++)
                {
                    gozuken_harfler.Add("_");
                }

                for (int i = 0; i < harf6cevaplar[secilen_index].ToString().Length; i++)
                {
                    kelime_alttre.Text += gozuken_harfler[i].ToString();
                    if (harf6cevaplar[secilen_index].ToString().Length - 1 > i)
                    {
                        kelime_alttre.Text += " ";
                    }
                }
                kacinci_soru_label.Text = "Kaçıncı Soru:" + soru_seviyesi;
                toplam_puan_label.Text = "Toplam Puan:" + puan;
                soru_puani_label.Text = "Soru Puani:" + soru_puani;
            }
            else if (soru_seviyesi == 7 || soru_seviyesi == 8)
            {
                kalan_harf_hakki = 6;
                tekrar_sec:
                int gecici_index_secimi = soru_sec.Next(0, harf6sorular.Count);
                if (secilen_index == gecici_index_secimi)
                {
                    goto tekrar_sec;
                }
                else
                {
                    secilen_index = gecici_index_secimi;
                }
                sorular_tb.Text = harf7sorular[secilen_index].ToString();
                soru_puani = harf7cevaplar[secilen_index].ToString().Length * 100;//HARF BAŞINA 100 PUAN
                var_olan_kelime = harf7cevaplar[secilen_index].ToString();
                kelime_alttre.Text = "";
                for (int i = 0; i < harf7cevaplar[secilen_index].ToString().Length; i++)
                {
                    gozuken_harfler.Add("_");
                }

                for (int i = 0; i < harf7cevaplar[secilen_index].ToString().Length; i++)
                {
                    kelime_alttre.Text += gozuken_harfler[i].ToString();
                    if (harf7cevaplar[secilen_index].ToString().Length - 1 > i)
                    {
                        kelime_alttre.Text += " ";
                    }
                }
                kacinci_soru_label.Text = "Kaçıncı Soru:" + soru_seviyesi;
                toplam_puan_label.Text = "Toplam Puan:" + puan;
                soru_puani_label.Text = "Soru Puani:" + soru_puani;
            }
            else if (soru_seviyesi == 9 || soru_seviyesi == 10)
            {
                kalan_harf_hakki = 7;
            tekrar_sec:
                int gecici_index_secimi = soru_sec.Next(0, harf6sorular.Count);
                if (secilen_index == gecici_index_secimi)
                {
                    goto tekrar_sec;
                }
                else
                {
                    secilen_index = gecici_index_secimi;
                }
                sorular_tb.Text = harf8sorular[secilen_index].ToString();
                soru_puani = harf8cevaplar[secilen_index].ToString().Length * 100;//HARF BAŞINA 100 PUAN
                var_olan_kelime = harf8cevaplar[secilen_index].ToString();
                kelime_alttre.Text = "";
                for (int i = 0; i < harf8cevaplar[secilen_index].ToString().Length; i++)
                {
                    gozuken_harfler.Add("_");
                }

                for (int i = 0; i < harf8cevaplar[secilen_index].ToString().Length; i++)
                {
                    kelime_alttre.Text += gozuken_harfler[i].ToString();
                    if (harf8cevaplar[secilen_index].ToString().Length - 1 > i)
                    {
                        kelime_alttre.Text += " ";
                    }
                }
                kacinci_soru_label.Text = "Kaçıncı Soru:" + soru_seviyesi;
                toplam_puan_label.Text = "Toplam Puan:" + puan;
                soru_puani_label.Text = "Soru Puani:" + soru_puani;
            }
            else if (soru_seviyesi == 11 || soru_seviyesi == 12)
            {
                kalan_harf_hakki = 8;
            tekrar_sec:
                int gecici_index_secimi = soru_sec.Next(0, harf6sorular.Count);
                if (secilen_index == gecici_index_secimi)
                {
                    goto tekrar_sec;
                }
                else
                {
                    secilen_index = gecici_index_secimi;
                }
                sorular_tb.Text = harf9sorular[secilen_index].ToString();
                soru_puani = harf9cevaplar[secilen_index].ToString().Length * 100;//HARF BAŞINA 100 PUAN
                var_olan_kelime = harf9cevaplar[secilen_index].ToString();
                kelime_alttre.Text = "";
                for (int i = 0; i < harf9cevaplar[secilen_index].ToString().Length; i++)
                {
                    gozuken_harfler.Add("_");
                }

                for (int i = 0; i < harf9cevaplar[secilen_index].ToString().Length; i++)
                {
                    kelime_alttre.Text += gozuken_harfler[i].ToString();
                    if (harf9cevaplar[secilen_index].ToString().Length - 1 > i)
                    {
                        kelime_alttre.Text += " ";
                    }
                }
                kacinci_soru_label.Text = "Kaçıncı Soru:" + soru_seviyesi;
                toplam_puan_label.Text = "Toplam Puan:" + puan;
                soru_puani_label.Text = "Soru Puani:" + soru_puani;
            }
            else if (soru_seviyesi == 13 || soru_seviyesi == 14)
            {
                kalan_harf_hakki = 9;
            tekrar_sec:
                int gecici_index_secimi = soru_sec.Next(0, harf6sorular.Count);
                if (secilen_index == gecici_index_secimi)
                {
                    goto tekrar_sec;
                }
                else
                {
                    secilen_index = gecici_index_secimi;
                }
                sorular_tb.Text = harf10sorular[secilen_index].ToString();
                soru_puani = harf10cevaplar[secilen_index].ToString().Length * 100;//HARF BAŞINA 100 PUAN
                var_olan_kelime = harf10cevaplar[secilen_index].ToString();
                kelime_alttre.Text = "";
                for (int i = 0; i < harf10cevaplar[secilen_index].ToString().Length; i++)
                {
                    gozuken_harfler.Add("_");
                }

                for (int i = 0; i < harf10cevaplar[secilen_index].ToString().Length; i++)
                {
                    kelime_alttre.Text += gozuken_harfler[i].ToString();
                    if (harf10cevaplar[secilen_index].ToString().Length - 1 > i)
                    {
                        kelime_alttre.Text += " ";
                    }
                }
                kacinci_soru_label.Text = "Kaçıncı Soru:" + soru_seviyesi;
                toplam_puan_label.Text = "Toplam Puan:" + puan;
                soru_puani_label.Text = "Soru Puani:" + soru_puani;
            }
            if (soru_seviyesi==15)
            {
                oyun_bitti();
            }
        }
        private void kelime_islem_foksiyon()//KELİME FOKSİYONU
        {
            try
            {
                for (int i = 4; i <= 11; i++)
                {
                    baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                    komut = new SqlCommand("select * from kelime_tablosu where LEN(kelime)=" + i, baglanti);//KULLANICI ADI PAROLA ARANAN KOMUT
                    oku = komut.ExecuteReader();//KOMUTLARI ÇALIŞTIRIP VERİLERİ SAKLADIĞIMIZ KOMUT
                    while (oku.Read())//EĞER VERİLER OKUNUYORSA DOĞRU BLOĞUNA GİRER.
                    {
                        if (i == 4)
                        {
                            harf4sorular.Add(oku["kelimenin_sorusu"].ToString());
                            harf4cevaplar.Add(oku["kelime"].ToString().ToUpper());
                        }
                        else if (i == 5)
                        {
                            harf5sorular.Add(oku["kelimenin_sorusu"].ToString());
                            harf5cevaplar.Add(oku["kelime"].ToString().ToUpper());
                        }
                        else if (i == 6)
                        {
                            harf6sorular.Add(oku["kelimenin_sorusu"].ToString());
                            harf6cevaplar.Add(oku["kelime"].ToString().ToUpper());
                        }
                        else if (i == 7)
                        {
                            harf7sorular.Add(oku["kelimenin_sorusu"].ToString());
                            harf7cevaplar.Add(oku["kelime"].ToString().ToUpper());
                        }
                        else if (i == 8)
                        {
                            harf8sorular.Add(oku["kelimenin_sorusu"].ToString());
                            harf8cevaplar.Add(oku["kelime"].ToString().ToUpper());
                        }
                        else if (i == 9)
                        {
                            harf9sorular.Add(oku["kelimenin_sorusu"].ToString());
                            harf9cevaplar.Add(oku["kelime"].ToString().ToUpper());
                        }
                        else if (i == 10)
                        {
                            harf10sorular.Add(oku["kelimenin_sorusu"].ToString());
                            harf10cevaplar.Add(oku["kelime"].ToString().ToUpper());
                        }
                    }
                    baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                }
            }
            catch (Exception HATA)
            {
                baglanti.Close();//EĞER HATA VERİRSE BAĞLANTIYI KAPATMA NEDENİ:BAĞLI YERE TEKRAR BAĞLANAMASSIN.
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.//HATA BİLGİSİ GÖSTERME
            }
        }

        private void soru_icin_sure_Tick(object sender, EventArgs e)
        {
            if (soru_sure > 0)
            {
                if (soru_sure % 60 == 0)
                {
                    sorularin_suresi_label.Text = "Süre:0" + soru_sure_dk + ":00";
                    soru_sure_dk--;
                }
                else
                {

                    if (soru_sure % 60 >= 10)
                    {
                        sorularin_suresi_label.Text = "Süre:0" + soru_sure_dk + ":" + soru_sure % 60;
                    }
                    else
                    {
                        sorularin_suresi_label.Text = "Süre:0" + soru_sure_dk + ":0" + soru_sure % 60;
                    }
                }

            }
            else
            {
                sorularin_suresi_label.Text = "Süre:00:00";
                sorularin_suresi_label.ForeColor = Color.Red;
                oyun_bitti();
            }
            soru_sure--;
        }
        Random harf_sec = new Random();
        int secilen_harf;
        private void button1_Click(object sender, EventArgs e)
        {
            if (kalan_harf_hakki > 0)
            {
                kelime_alttre.Text = "";
                bool durum = true;
                if (soru_seviyesi == 1 || soru_seviyesi == 2)
                {
                    while (durum == true)
                    {
                        secilen_harf = harf_sec.Next(0, var_olan_kelime.Length);
                        if (gozuken_harfler[secilen_harf] == "_")
                        {
                            gozuken_harfler[secilen_harf] = var_olan_kelime[secilen_harf];
                            soru_puani -= 100;
                            durum = false;
                        }
                    }

                    for (int i = 0; i < harf4cevaplar[secilen_index].ToString().Length; i++)
                    {
                        kelime_alttre.Text += gozuken_harfler[i].ToString();
                        if (harf4cevaplar[secilen_index].ToString().Length - 1 > i)
                        {
                            kelime_alttre.Text += " ";
                        }
                    }
                    soru_puani_label.Text = "Soru Puani:" + soru_puani;
                    kalan_harf_hakki--;
                    if (kalan_harf_hakki == 0)
                    {
                        button1.Enabled = false;
                        cevap_btn.PerformClick();
                    }
                }
                else if (soru_seviyesi == 3 || soru_seviyesi == 4)
                {
                    while (durum == true)
                    {
                        secilen_harf = harf_sec.Next(0, var_olan_kelime.Length);
                        if (gozuken_harfler[secilen_harf] == "_")
                        {
                            gozuken_harfler[secilen_harf] = var_olan_kelime[secilen_harf];
                            soru_puani -= 100;
                            durum = false;
                        }
                    }

                    for (int i = 0; i < harf5cevaplar[secilen_index].ToString().Length; i++)
                    {
                        kelime_alttre.Text += gozuken_harfler[i].ToString();
                        if (harf5cevaplar[secilen_index].ToString().Length - 1 > i)
                        {
                            kelime_alttre.Text += " ";
                        }
                    }
                    soru_puani_label.Text = "Soru Puani:" + soru_puani;
                    kalan_harf_hakki--;
                    if (kalan_harf_hakki == 0)
                    {
                        button1.Enabled = false;
                        cevap_btn.PerformClick();
                    }
                }
                else if (soru_seviyesi == 5 || soru_seviyesi == 6)
                {
                    while (durum == true)
                    {
                        secilen_harf = harf_sec.Next(0, var_olan_kelime.Length);
                        if (gozuken_harfler[secilen_harf] == "_")
                        {
                            gozuken_harfler[secilen_harf] = var_olan_kelime[secilen_harf];
                            soru_puani -= 100;
                            durum = false;
                        }
                    }

                    for (int i = 0; i < harf6cevaplar[secilen_index].ToString().Length; i++)
                    {
                        kelime_alttre.Text += gozuken_harfler[i].ToString();
                        if (harf6cevaplar[secilen_index].ToString().Length - 1 > i)
                        {
                            kelime_alttre.Text += " ";
                        }
                    }
                    soru_puani_label.Text = "Soru Puani:" + soru_puani;
                    kalan_harf_hakki--;
                    if (kalan_harf_hakki == 0)
                    {
                        button1.Enabled = false;
                        cevap_btn.PerformClick();
                    }
                }
                else if (soru_seviyesi == 7 || soru_seviyesi == 8)
                {
                    while (durum == true)
                    {
                        secilen_harf = harf_sec.Next(0, var_olan_kelime.Length);
                        if (gozuken_harfler[secilen_harf] == "_")
                        {
                            gozuken_harfler[secilen_harf] = var_olan_kelime[secilen_harf];
                            soru_puani -= 100;
                            durum = false;
                        }
                    }

                    for (int i = 0; i < harf7cevaplar[secilen_index].ToString().Length; i++)
                    {
                        kelime_alttre.Text += gozuken_harfler[i].ToString();
                        if (harf7cevaplar[secilen_index].ToString().Length - 1 > i)
                        {
                            kelime_alttre.Text += " ";
                        }
                    }
                    soru_puani_label.Text = "Soru Puani:" + soru_puani;
                    kalan_harf_hakki--;
                    if (kalan_harf_hakki == 0)
                    {
                        button1.Enabled = false;
                        cevap_btn.PerformClick();
                    }
                }
                else if (soru_seviyesi == 9 || soru_seviyesi == 10)
                {
                    while (durum == true)
                    {
                        secilen_harf = harf_sec.Next(0, var_olan_kelime.Length);
                        if (gozuken_harfler[secilen_harf] == "_")
                        {
                            gozuken_harfler[secilen_harf] = var_olan_kelime[secilen_harf];
                            soru_puani -= 100;
                            durum = false;
                        }
                    }

                    for (int i = 0; i < harf8cevaplar[secilen_index].ToString().Length; i++)
                    {
                        kelime_alttre.Text += gozuken_harfler[i].ToString();
                        if (harf8cevaplar[secilen_index].ToString().Length - 1 > i)
                        {
                            kelime_alttre.Text += " ";
                        }
                    }
                    soru_puani_label.Text = "Soru Puani:" + soru_puani;
                    kalan_harf_hakki--;
                    if (kalan_harf_hakki == 0)
                    {
                        button1.Enabled = false;
                        cevap_btn.PerformClick();
                    }
                }
                else if (soru_seviyesi == 11 || soru_seviyesi == 12)
                {
                    while (durum == true)
                    {
                        secilen_harf = harf_sec.Next(0, var_olan_kelime.Length);
                        if (gozuken_harfler[secilen_harf] == "_")
                        {
                            gozuken_harfler[secilen_harf] = var_olan_kelime[secilen_harf];
                            soru_puani -= 100;
                            durum = false;
                        }
                    }

                    for (int i = 0; i < harf9cevaplar[secilen_index].ToString().Length; i++)
                    {
                        kelime_alttre.Text += gozuken_harfler[i].ToString();
                        if (harf9cevaplar[secilen_index].ToString().Length - 1 > i)
                        {
                            kelime_alttre.Text += " ";
                        }
                    }
                    soru_puani_label.Text = "Soru Puani:" + soru_puani;
                    kalan_harf_hakki--;
                    if (kalan_harf_hakki == 0)
                    {
                        button1.Enabled = false;
                        cevap_btn.PerformClick();
                    }
                }
                else if (soru_seviyesi == 13 || soru_seviyesi == 14)
                {
                    while (durum == true)
                    {
                        secilen_harf = harf_sec.Next(0, var_olan_kelime.Length);
                        if (gozuken_harfler[secilen_harf] == "_")
                        {
                            gozuken_harfler[secilen_harf] = var_olan_kelime[secilen_harf];
                            soru_puani -= 100;
                            durum = false;
                        }
                    }

                    for (int i = 0; i < harf10cevaplar[secilen_index].ToString().Length; i++)
                    {
                        kelime_alttre.Text += gozuken_harfler[i].ToString();
                        if (harf10cevaplar[secilen_index].ToString().Length - 1 > i)
                        {
                            kelime_alttre.Text += " ";
                        }
                    }
                    soru_puani_label.Text = "Soru Puani:" + soru_puani;
                    kalan_harf_hakki--;
                    if (kalan_harf_hakki == 0)
                    {
                        button1.Enabled = false;
                        cevap_btn.PerformClick();
                    }
                }
            }
        }

        private void cevap_btn_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            soru_icin_sure.Stop();
            kelime_bul_gp.Enabled = true;
            cevaplama_suresi.Interval = 1000;
            cevaplama_suresi.Start();
        }

        private void kelime_bul_button_Click(object sender, EventArgs e)
        {
            if (kelime_bulma_tb.Text.ToUpper() == var_olan_kelime)
            {
                gozuken_harfler.Clear();
                puan += soru_puani;
                secilen_index = -1;
                soru_getir_fk();
                soru_icin_sure.Start();
                kelime_bul_gp.Enabled = false;
                cevaplama_suresi_degisken = 30;
                cevaplama_suresi.Stop();
                cevaplama_suresi_label.Text = "Süre:";
                kelime_bulma_tb.Text = "";
                button1.Enabled = true;
            }
        }
        int cevaplama_suresi_degisken = 30;
        private void cevaplama_suresi_Tick(object sender, EventArgs e)
        {
            if (cevaplama_suresi_degisken >= 0)
            {
                if (cevaplama_suresi_degisken >= 10)
                {
                    cevaplama_suresi_label.Text = "Süre:" + cevaplama_suresi_degisken;
                    cevaplama_suresi_label.ForeColor = Color.Green;
                }
                else
                {
                    cevaplama_suresi_label.Text = "Süre:0" + cevaplama_suresi_degisken;
                    cevaplama_suresi_label.ForeColor = Color.Red;
                }
            }
            if (cevaplama_suresi_degisken <= 0)
            {
                oyun_bitti();
            }
            cevaplama_suresi_degisken--;
        }

        private void oyun_bitti()
        {
            this.Enabled = false;
            soru_icin_sure.Stop();
            cevaplama_suresi.Stop();
            if (MessageBox.Show("BİLDİĞİNİZ SORU SAYISI:"+(soru_seviyesi-1)+"\nPUAN:"+puan+"\nSAYIN "+Oyun_Giris_Penceresi.adi_soyadi.ToUpper()+"\nPUANINIZ KAYIT EDİLSİN Mİ ?", "SORU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Ekle();
            }
            Application.Exit();
        }
        private void Ekle()//KELİME EKLEME KOMUTLARI
        {
            try
            {
                baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
                komut = new SqlCommand("insert into yarismaci_tablosu values('" + Oyun_Giris_Penceresi.kayit_kodu + "','" + Oyun_Giris_Penceresi.adi_soyadi + "'," + puan + ")", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show("PUANINIZ LİSTEYE EKLENDİ.", "PUAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception HATA)
            {
                baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
                MessageBox.Show(HATA.ToString() + "\nSİSTEM DIŞI HATA OLUŞMUŞTUR...", "KONTROL DIŞI HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);//HATA BİLGİSİ MESAJ PENCERESİ İLE KULLANICIYA GÖSTERİLDİ.
            }
        }
    }
}
