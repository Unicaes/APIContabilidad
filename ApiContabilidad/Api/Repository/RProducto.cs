using Api.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Api.Repository
{
    public class RProducto:IProducto
    {
        private Model1 c = new Model1();
        public bool Delete(int id)
        {
            var resp = c.Producto.Find(id);
            if (resp == null)
            {
                return false;
            }
            c.Producto.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public IEnumerable<Producto> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Producto.Include(d=>d.Proveedor).ToList();
            }
        }

        public Producto GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            return c.Producto.Find(id);
        }

        public Producto Post(Producto item)
        {
            if (item == null)
            {
                return null;
            }
            c.Producto.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id, Producto item)
        {
            var resp = c.Producto.Find(id);
            if (resp == null)
            {
                return false;
            }
            resp.id_proveedor = item.id_proveedor;
            resp.nombre = item.nombre;
            c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
            c.SaveChanges();
            return true;
        }
    }
}