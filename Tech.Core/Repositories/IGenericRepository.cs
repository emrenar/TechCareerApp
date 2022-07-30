﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tech.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {

        Task<T> GetByIdAsync(int Id);

        IQueryable<T> GetAll();

        Task AddAsync(T entity);

        void Update(T entity);

        void Remove(T entity);
    }
}
