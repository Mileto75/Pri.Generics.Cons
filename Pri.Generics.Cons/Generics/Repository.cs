using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Generics.Cons.Generics
{
    public class Repository<T> : IRepository<T>
    {
        private List<T> _items = new List<T>();
        public void Add(T toAdd)
        {
            _items.Add(toAdd);
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public T GetById(int index)
        {
            return _items[index];
        }

        public void Remove(T toRemove)
        {
            _items.Remove(toRemove);
        }
    }
}
