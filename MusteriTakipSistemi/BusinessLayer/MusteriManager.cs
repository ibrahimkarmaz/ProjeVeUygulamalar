using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntitiyLayer.Entities;

namespace BusinessLayer
{
    public class MusteriManager
    {
        Repository<MusteriTablosu> repositoryMusteri = new Repository<MusteriTablosu>();
        public List<MusteriTablosu> TumunuListele()
        {
            return repositoryMusteri.Liste();
        }
        public int Kaydet(MusteriTablosu p)
        {
            return repositoryMusteri.Insert(p);
        }
    }
}
