﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RedCloud.Application.Contract.Persistence
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        //Eager Loading of Related Data   ---------------------------
        Task<T> GetByIdAsyncInculde(int id);

        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IReadOnlyList<T>> GetPagedReponseAsync(int page, int size);
        
        //extra method 
        Task<IEnumerable<T>> GetAllAsync(string includeProperties = "");

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
    }
}
