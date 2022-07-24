using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using EntitiyLayer.Entities;

namespace MusteriTakipSistemi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        MusteriManager managerMusteri= new MusteriManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            MListele();
        }
        private void MListele()
        {
            gridControl1.DataSource = managerMusteri.TumunuListele();
            dataGridView1.DataSource = managerMusteri.TumunuListele();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            MusteriTablosu musteriTablosu = new MusteriTablosu();
            musteriTablosu.ad = textEdit1.Text;
            musteriTablosu.soyad = textEdit2.Text;
            managerMusteri.Kaydet(musteriTablosu);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            MListele();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
