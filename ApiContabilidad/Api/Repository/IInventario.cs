using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    interface IInventario
    {
        IEnumerable<Inventario> GetAll();
        Inventario GetById(int id);
        Inventario Post(Inventario item);
        bool Put(int id, Inventario item);
        bool Delete(int id);

    }
}
