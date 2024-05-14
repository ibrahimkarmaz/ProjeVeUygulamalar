using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using System.Collections;

namespace HelpDesk
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        ArrayList TaskNameArrayList = new ArrayList();

        private void ReadDataFromCSV(string csvFilePath, string fieldName)
        {
            Console.WriteLine("1 GÖREV BÖLGESİ");
            if (!File.Exists(csvFilePath))
            {
                Console.WriteLine("CSV dosyası bulunamadı.");
                return;
            }
            // CsvHelper kullanarak CSV dosyasını oku
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(System.Globalization.CultureInfo.InvariantCulture)))
            {
                // CsvHelper, her satırı sözlük olarak okuyabilir
              //  csv.Configuration.HasHeaderRecord = true;
                csv.Read();
                csv.ReadHeader();
              
                while (csv.Read())
                {
                    // Belirtilen alan adını kullanarak veriye erişme
                    string fieldValue = csv.GetField(fieldName);
                    //Console.WriteLine($"{fieldName}: {fieldValue}");
                    TaskNameArrayList.Add($"{fieldValue}");
                }
               
            }
            CreateCheckEdits(TaskNameArrayList.Count);
        }
        private void CreateCheckEdits(int TaskCount)
        {
            const int startX = 20;
            const int startY = 20;
            const int paddingY = 30;
            const int checkEditWidth = 150;
            const int checkEditHeight = 20;
            const int groupControlWidth = 200;
            const int groupControlHeight = 300;

            GroupControl groupControl = new GroupControl();
            groupControl.Text = "Görevler";
            groupControl.Size = new System.Drawing.Size(groupControlWidth, groupControlHeight);
            groupControl.Location = new System.Drawing.Point(startX, startY);
            groupControl.Dock = DockStyle.Fill;
           // groupControl.InvertTouchScroll = true;

            // 10 tane CheckBox oluştur
            for (int i = TaskCount; i > 0; i--)
            {
                CheckEdit checkEdit = new CheckEdit();
                checkEdit.Text = TaskNameArrayList[i-1].ToString();
                checkEdit.Location = new System.Drawing.Point(10, 20 + i * (checkEditHeight + paddingY));
                checkEdit.Size = new System.Drawing.Size(checkEditWidth, checkEditHeight);
                checkEdit.CheckedChanged += CheckEdit_CheckedChanged;
                checkEdit.Dock = DockStyle.Top;

                groupControl.Controls.Add(checkEdit);
            }

            fluentDesignFormContainer1.Controls.Add(groupControl);


        }

        private void CheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox durumu değiştiğinde burada işlem yapabilirsiniz.
            CheckEdit checkEdit = sender as CheckEdit;
            if (checkEdit != null)
            {
                //MessageBox.Show($"{checkEdit.Text} durumu değişti. Yeni durum: {checkEdit.Checked}");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string csvFilePath = "TaskConfig.csv";

            // CSV dosyasından belirli bir alan adı ile veri okuma
            ReadDataFromCSV(csvFilePath, "Task");
        }
    }
}
