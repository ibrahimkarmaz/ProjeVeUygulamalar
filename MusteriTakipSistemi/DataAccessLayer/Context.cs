using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer.Entities;

namespace DataAccessLayer
{
    public class Context:DbContext
    {
        public DbSet<MusteriTablosu> Musteri { get; set; }
        public DbSet<iller> il { get; set; }
        public DbSet<ilceler> ilce { get; set; }
        public DbSet<giris_tablosu> GirisTablosu { get; set; }

    }
}
