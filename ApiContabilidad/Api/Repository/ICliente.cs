using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiContabilidad.Repository
{
    public interface ICliente
    {
        IEnumerable<Cliente> GetAll();
        Cliente GetById(int id);
        Cliente Post(Cliente item);
        bool Put(int id,Cliente item);
        bool Delete(int id);

    }
}
