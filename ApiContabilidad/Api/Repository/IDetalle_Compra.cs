using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    interface IDetalle_Compra
    {
        IEnumerable<Detalle_Compra> GetAll();
        Detalle_Compra GetById(int id);
        Detalle_Compra Post(Detalle_Compra item);
        bool Put(int id, Detalle_Compra item);
        bool Delete(int id);
    }
}
