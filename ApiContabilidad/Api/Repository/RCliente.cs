using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiContabilidad.Repository
{
    public class RCliente : ICliente
    {
        private Model1 c = new Model1();
        public bool Delete(int id)
        {
            var resp = c.Cliente.Find(id);
            if (resp==null)
            {
                return false;
            }
            c.Cliente.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public IEnumerable<Cliente> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Cliente.ToList();
            }
        }

        public Cliente GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            return c.Cliente.Find(id);
        }

        public Cliente Post(Cliente item)
        {
            if (item == null)
            {
                return null;
            }
            c.Cliente.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id,Cliente item)
        {
            var resp = c.Cliente.Find(id);
            if (resp == null)
            {
                return false;
            }
            resp.apellido = item.apellido;
            resp.nombre = item.nombre;
            c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
            c.SaveChanges();
            return true;
        }
    }
}