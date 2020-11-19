using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repository
{
    public class RCompra:ICompra
    {
        private Model1 c = new Model1();
        public bool Delete(int id)
        {
            var resp = c.Compra.Find(id);
            if (resp == null)
            {
                return false;
            }
            c.Compra.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public IEnumerable<Compra> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Compra.ToList();
            }
        }

        public Compra GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            return c.Compra.Find(id);
        }

        public Compra Post(Compra item)
        {
            if (item == null)
            {
                return null;
            }
            c.Compra.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id, Compra item)
        {
            var resp = c.Compra.Find(id);
            if (resp == null)
            {
                return false;
            }
            resp.fecha = item.fecha;
            resp.iva = item.iva;
            resp.num_factura = item.num_factura;
            resp.subtotal = item.subtotal;
            resp.total = item.total;
            c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
            c.SaveChanges();
            return true;
        }
    }
}