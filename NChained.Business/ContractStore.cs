using System;
using NChained.Business.Contract;
using System.Collections.Generic;
using System.Linq;

namespace NChained.Business
{
    public class Store<T> : IStore<T>
    {

        IList<T> _store = new List<T>();

        //public T Get(Guid identifier)
        //{
        //   // if (_store.ContainsKey(identifier))
        //        return _store[identifier];          
        //}

        public IList<T> GetAll()
        {            
            return _store.ToList<T>();
        }

        public void  Put(T item)
        {
            var id = Guid.NewGuid();
            _store.Add(item);
        }
    }
}
