using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;//KlASOR İŞLEMLERİ
using DevExpress.XtraEditors;

namespace KlasorIslemleri
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Special:Özel
        //Environment:Çevre
        private void simpleButton1_Click(object sender, EventArgs e)
        {//Masaüstüne klasor açma
            string MasaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Directory.CreateDirectory(MasaustuYolu + "\\"+textEdit1.Text);
            XtraMessageBox.Show(textEdit1.Text+" MASAÜSTÜNE KLASÖR OLUŞTURULDU.");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string MasaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Directory.Delete(MasaustuYolu+"\\"+textEdit1.Text,true);//EĞER TRUE GELİYORSA İÇİNDE VERİ VARSA ONLARIDA SİLER
            XtraMessageBox.Show(textEdit1.Text + " MASAÜSTÜNE KLASÖR SİLİNDİ.");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string MasaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if (Directory.Exists(MasaustuYolu+"\\"+textEdit1.Text))
            {
                XtraMessageBox.Show("MASAÜSTÜNDE MEVCUTTUR.");
            }
            else
            {
                XtraMessageBox.Show("MASAÜSTÜNDE MEVCUT DEĞİLDİR.");
            }

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {////GetFiles metodu dosyaları temsil eder. Belirtilen Dizindeki Dosyaları Dizi olarak döndürür

            listBoxControl1.Items.Clear();
            string MasaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            foreach (var item in Directory.GetFiles(MasaustuYolu))
            {
                listBoxControl1.Items.Add(item);
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {//DİKKAT AYNI BÖLGE İÇİNDE TAŞIMA YAPILABİLİR YANI C'DE İSE CDEN BAŞKA BİR YERE :)

            string MasaustuYolu = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Directory.Move(MasaustuYolu+"\\"+textEdit1.Text, MasaustuYolu + "\\HASAR\\" + textEdit1.Text);
        }
    }
}
/*EKSTRA ÖZELLİKLER
 * Klasör byte boyutu için;
    System.IO.FileInfo dosya = new System.IO.FileInfo("D:serkan.xlsx");
    MessageBox.Show(dosya.Length.ToString());
 *Dosyaya son erişimin ne zaman olduğunu bulmak için;
    MessageBox.Show(System.IO.Directory.GetLastAccessTime("D:ahmet").ToString());
 */

//KAYNAK 1:https://www.aspsnippets.com/questions/212407/Create-a-folder-or-directory-on-users-desktop-in-windows-application-C/
//KAYNAK 2:https://www.yazilimkodlama.com/programlama/c-klasor-ve-dosya-islemleri-directory/