using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    interface ICompra
    {
        IEnumerable<Compra> GetAll();
        Compra GetById(int id);
        Compra Post(Compra item);
        bool Put(int id, Compra item);
        bool Delete(int id);
    }
}
