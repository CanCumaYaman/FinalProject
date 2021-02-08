
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class :class olabilir değil referans tip olabilir demek
    //IEntity : IEntity olabilir yada Ientity implemete eden bir nesne olabilir
    //new(): newlenebilir olmalı
    //Core katmanının amacı diğer katmanlara bağımsız olmak o yüzden proje referansı almaz
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
