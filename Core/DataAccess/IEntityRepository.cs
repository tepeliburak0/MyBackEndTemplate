using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;


namespace Core.DataAccess
{
    //Generic Constraint
    //T tipinde herhangi bir gelen enitity'nin sorgularının listesi.
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
       //Bussines katmanında Linq sorguları ve filtreleri yapılabilmesi için Expression kullanılır.
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
