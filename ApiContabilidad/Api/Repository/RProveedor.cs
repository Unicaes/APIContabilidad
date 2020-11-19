using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repository
{
    public class RProveedor:IProveedor
    {
        private Model1 c = new Model1();
        public bool Delete(int id)
        {
            var resp = c.Proveedor.Find(id);
            if (resp == null)
            {
                return false;
            }
            c.Proveedor.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public IEnumerable<Proveedor> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Proveedor.ToList();
            }
        }

        public Proveedor GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            return c.Proveedor.Find(id);
        }

        public Proveedor Post(Proveedor item)
        {
            if (item == null)
            {
                return null;
            }
            c.Proveedor.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id, Proveedor item)
        {
            var resp = c.Proveedor.Find(id);
            if (resp == null)
            {
                return false;
            }
            resp.nombre = item.nombre;
            c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
            c.SaveChanges();
            return true;
        }
    }
}