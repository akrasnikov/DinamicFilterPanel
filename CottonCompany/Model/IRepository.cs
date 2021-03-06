﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottonCompany.Model
{
    interface IRepository<T> : IDisposable
        where T : class
    {

        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
