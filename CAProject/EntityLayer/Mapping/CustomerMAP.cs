﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EntityLayer.Concrete;

namespace EntityLayer.Mapping
{
    public class CustomerMAP:EntityTypeConfiguration<Customer>
    {
        public CustomerMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Customers");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.CustomerID);

            //BENZERSİZ ALANLAR
            this.HasIndex(x => x.CustomerTC).IsUnique();
            this.HasIndex(x => x.CustomerMobilePhone).IsUnique();
            this.HasIndex(x => x.CustomerOfficePhone).IsUnique();
            this.HasIndex(x => x.CustomerTaxNumber).IsUnique();
            this.HasIndex(x => x.CustomerMail).IsUnique();



            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.CustomerName).HasMaxLength(20);
            this.Property(x => x.CustomerSurName).HasMaxLength(20);
            this.Property(x => x.CustomerMobilePhone).HasMaxLength(15);
            this.Property(x => x.CustomerOfficePhone).HasMaxLength(15);
            this.Property(x => x.CustomerTC).HasMaxLength(11);
            this.Property(x => x.CustomerMail).HasMaxLength(40);
            this.Property(x => x.CustomerTown).HasMaxLength(13);
            this.Property(x => x.CustomerCounty).HasMaxLength(20);
            this.Property(x => x.CustomerHomeAddress).HasMaxLength(250);
            this.Property(x => x.CustomerTaxNumber).HasMaxLength(30);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.CustomerName).IsRequired();
            this.Property(y => y.CustomerSurName).IsRequired();
            this.Property(y => y.CustomerMobilePhone).IsRequired();
            this.Property(y => y.CustomerTC).IsRequired();
            this.Property(y => y.CustomerTown).IsRequired();
            this.Property(y => y.CustomerCounty).IsRequired();
            this.Property(y => y.CustomerHomeAddress).IsRequired();
            this.Property(y => y.CustomerTaxNumber).IsRequired();
            this.Property(y => y.CustomerArchive).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI CUSTOMER İÇİNDEKİ GİBİ DEVAM EDER EĞER CUSTOMERDA YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.CustomerID).HasColumnName("CustomerID");
            this.Property(z => z.CustomerTC).HasColumnName("CustomerTC");
            this.Property(z => z.CustomerName).HasColumnName("CustomerName");
            this.Property(z => z.CustomerSurName).HasColumnName("CustomerSurName");
            this.Property(z => z.CustomerMobilePhone).HasColumnName("CustomerMobilePhone");
            this.Property(z => z.CustomerOfficePhone).HasColumnName("CustomerOfficePhone");
            this.Property(z => z.CustomerMail).HasColumnName("CustomerMail");
            this.Property(z => z.CustomerTown).HasColumnName("CustomerTown");
            this.Property(z => z.CustomerCounty).HasColumnName("CustomerCounty");
            this.Property(z => z.CustomerHomeAddress).HasColumnName("CustomerHomeAddress");
            this.Property(z => z.CustomerTaxNumber).HasColumnName("CustomerTaxNumber");
            this.Property(z => z.CustomerArchive).HasColumnName("CustomerArchive");


            //VERİ TİPLERİ
            this.Property(d => d.CustomerTC).HasColumnType("char");
        }
    }
}
