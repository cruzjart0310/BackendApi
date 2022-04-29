﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talent.Backend.Bussiness.Models;

namespace Talent.Backend.Bussiness.Contracts
{
    public interface IBussines<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(Pagination pagination);
        Task<T> GetAsync(int id);
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(int id, T entity);
        Task DeleteAsync(T entity);
    }
}
