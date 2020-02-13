using System;
using System.Collections.Generic;
using System.Linq;

namespace DatingApp.Repositories.Contracts
{
    public interface IRepository<TEntity> where TEntity : class 
    {
         IEnumerable<TEntity> Get();
        TEntity GetById(object id);
        TEntity Insert(TEntity entity);
        void Update(TEntity obj);
        void Delete(object id);
    }
}