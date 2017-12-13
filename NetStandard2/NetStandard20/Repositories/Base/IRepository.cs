using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NetStandard2.DbConnection;

namespace NetStandard2.Repositories.Base
{
    public interface IRepository<T> where T : class
    {
        DatabaseContext Context { get; }
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(string id);
        //CRUD
        Task Insert(T item);
        Task Delete(T item);
        Task Update(T item);

    }
}
