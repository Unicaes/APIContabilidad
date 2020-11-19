using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    interface IProveedor
    {
        IEnumerable<Proveedor> GetAll();
        Proveedor GetById(int id);
        Proveedor Post(Proveedor item);
        bool Put(int id, Proveedor item);
        bool Delete(int id);
    }
}
