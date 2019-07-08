using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KharkivPhotoes.Interfaces
{
    interface IRepository<T>
    {
        int Create(T item);

        void Delete(int id);

        IEnumerable<T> GetAll();

        T Get(int id);

        void Save();

        void Update(T item);
    }
}
