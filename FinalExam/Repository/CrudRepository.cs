using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalExam.Repository
{
 
    public abstract class CrudRepository<T> : Repository
    {

        public abstract T Save(T entity);
        public abstract List<T> GetAll();
        public abstract T Get(long id);
        public abstract bool Delete(T entity);
        public abstract T Update(long id, T entity);
    }
}