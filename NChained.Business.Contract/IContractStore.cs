using System;
using System.Collections.Generic;

namespace NChained.Business.Contract
{
    public interface IStore<T>
    {
        void Put(T Contract);
      //  T Get(Guid identifier);
        IList<T> GetAll();
    }
}
