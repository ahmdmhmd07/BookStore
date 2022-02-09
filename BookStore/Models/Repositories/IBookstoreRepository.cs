﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
   public interface IBookstoreRepository <TEntity>
    {
        IList<TEntity> List();
        TEntity find(int id);
        void Add(TEntity entity);
        void Update(int id , TEntity entity);
        void Delete(int id);
        List<TEntity> Search(string term);
    }
}
