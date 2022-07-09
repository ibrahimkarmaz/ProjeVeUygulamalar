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
    public partial class top_x_penceresi : Form
    {
        public top_x_penceresi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(Oyun_Giris_Penceresi.global_baglanti_adresi);
        SqlDataAdapter Komutlar;//TABLOLARIN ÇEKİLMESİNDE KULLANILAN KOMUT
        SqlCommand komut;//SQL İFADELERİNİ ÇALIŞTIRAN KOMUT
        DataSet veriseti = new DataSet();//ÇEKİLEN TABLOLARI SAKLAMAK İÇİN GEREK KOMUT
        private void top_x_penceresi_Load(object sender, EventArgs e)
        {
            top50_listesini_getir();
            top50_listesini_duzenle();
        }
        private void top50_listesini_getir()//KELİME BİLGİLERİNİ GETİRME
        {
            veriseti.Clear();//TABLOLARI SİLER 
            baglanti.Open();//VERİTABANINA BAĞLANTI AÇILDI
            Komutlar = new SqlDataAdapter("select top 50 upper(ad_soyad) as 'isim_soyisim',puani from yarismaci_tablosu order by puani desc", baglanti);//KELİME BİLGİLERİ
            Komutlar.Fill(veriseti, "yarismaci_tablosu");
            baglanti.Close();//VERİTABANI BAĞLANTISI KAPATILDI
            tablolari_listele_dgv.DataSource = veriseti.Tables["yarismaci_tablosu"];//PERSONEL TABLOSUNDA GÖSTERME

        }
        private void top50_listesini_duzenle()//ALANLARI DÜZENLEME
        {
            tablolari_listele_dgv.Columns["isim_soyisim"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ
            tablolari_listele_dgv.Columns["puani"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;//OTOMATİK BOYUTLANDIRMA İŞLEMLERİ


            tablolari_listele_dgv.Columns["isim_soyisim"].HeaderText = "ADI VE SOYADI";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞTİRİLİR.
            tablolari_listele_dgv.Columns["puani"].HeaderText = "PUANI";//VERİTABANINDA GÖZÜKEN ALAN ADI DEĞİŞ        
        }
    }
}
