using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    interface IGeneral<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Post(T item);
        bool Put(int id, T item);
        bool Delete(int id);
    }
}
