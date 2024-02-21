using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Generics.Cons.Generics
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int index);
        void Add(T toAdd);
        void Remove(T toRemove);
    }
}
