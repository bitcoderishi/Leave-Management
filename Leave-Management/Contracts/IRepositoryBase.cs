﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management.Contracts
{
    public interface IRepositoryBase<T> where T : class
    {
        ICollection<T> FindAll();
        T FindById(int id);
        bool isExist(int id);
        bool Delete(T entity);
        bool Create(T entity);
        bool Update(T entity);
        bool Save();
    }
}
