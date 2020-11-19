using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    interface IProducto
    {
        IEnumerable<Producto> GetAll();
        Producto GetById(int id);
        Producto Post(Producto item);
        bool Put(int id, Producto item);
        bool Delete(int id);
    }
}
