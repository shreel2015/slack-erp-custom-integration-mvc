﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Promact.Erp.DomainModel.DataRepository
{
    public interface IRepository<T> : IDisposable
    {
        IQueryable<T> GetAll();
        T GetById(int? id);
        void Insert(T entity);
        void Delete(int? id);
        void Update(T entity);
        void Save();
        T FirstOrDefault(Expression<Func<T, bool>> predicate);
        IQueryable<T> Fetch(Func<T, bool> predicate);
        Task<IEnumerable<T>> FetchAsync(Expression<Func<T, bool>> predicate);
        bool Any(Func<T, bool> predicate);
        bool All(Func<T, bool> predicate);
        T LastOrDefault(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    }
}
