﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        int Insert(T p);
        int update(T P);

        int Delete(T p);

        List<T> List();
        T GetById(int id);
    }
}
