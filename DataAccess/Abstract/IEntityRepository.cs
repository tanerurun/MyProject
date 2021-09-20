using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   // new():new'lenebilir olmalı
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        //buradaki expression getirme işlemleirn tümünü yapar tek tek gid category yada ıd göre getir tümünü bu expression yapıyor 
        //bir bankada birden fazla hesabınızı varsa expression ile listeliyoruz. aşağıdaki de bu hesaplaranda tıklaıdğımızı getiriyor.mantık bu şekilde
        //filter=null demek filtere vermesende olur demek
        T Get(Expression <Func<T,bool>> filter);
        //bankada bir kişinin bilgilerini getirmek gibi tek bir kişi bilgisine ulaşmak için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
 
    }
}

 