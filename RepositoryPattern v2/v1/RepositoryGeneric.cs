using RepositoyPattern.v1;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern
{
    class RepositoryGeneric<T> where T:EntityBase
    {
        public virtual void Add(T entity)
        {
            entity.Id = EntityBase.CreateIdentifier();
        }   
    }
}
