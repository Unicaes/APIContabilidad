using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    interface IEmpleado
    {
        IEnumerable<Empleado> GetAll();
        Empleado GetById(int id);
        Empleado Post(Empleado item);
        bool Put(int id, Empleado item);
        bool Delete(int id);
    }
}
