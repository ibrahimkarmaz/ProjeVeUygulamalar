using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;


namespace DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context DbTablolar = new Context();
        DbSet<T> _Objem;
        //ctor yazınca Bu classta kullanılacak(çağrıldığında) yapıyı getirir.
        public Repository()
        {
            _Objem = DbTablolar.Set<T>();
        }
        public int Delete(T p)
        {
            _Objem.Remove(p);
            return DbTablolar.SaveChanges();
        }

        public T GetById(int id)
        {
            return _Objem.Find(id);
        }

        public int Insert(T p)
        {
            _Objem.Add(p);
            return DbTablolar.SaveChanges();
        }

        public List<T> Liste()
        {
            return _Objem.ToList();
        }

        public int update(T P)
        {
            return DbTablolar.SaveChanges();
        }
    }
}
