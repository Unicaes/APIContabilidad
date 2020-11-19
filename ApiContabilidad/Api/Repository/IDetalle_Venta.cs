using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    interface IDetalle_Venta
    {
        IEnumerable<Detalle_Venta> GetAll();
        Detalle_Venta GetById(int id);
        Detalle_Venta Post(Detalle_Venta item);
        bool Put(int id, Detalle_Venta item);
        bool Delete(int id);
    }
}
