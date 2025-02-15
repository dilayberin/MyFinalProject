﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //class:referans tip
    //IEntity: IEntity veya IEntity implemente eden bir nesne olabilir
    //new():new lenebilir olmalı
    public interface IEntityRepository<T> where T : class,IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);    
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
