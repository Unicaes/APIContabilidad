using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    interface IVenta
    {
        IEnumerable<Venta> GetAll();
        Venta GetById(int id);
        Venta Post(Venta item);
        bool Put(int id, Venta item);
        bool Delete(int id);
    }
}
