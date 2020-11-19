using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Api.Repository
{
    public class RVenta:IVenta
    {
        private Model1 c = new Model1();
        public bool Delete(int id)
        {
            var resp = c.Venta.Find(id);
            if (resp == null)
            {
                return false;
            }
            c.Venta.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public IEnumerable<Venta> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Venta.Include(d=>d.Cliente).Include(d=>d.Empleado).ToList();
            }
        }

        public Venta GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            return c.Venta.Find(id);
        }

        public Venta Post(Venta item)
        {
            if (item == null)
            {
                return null;
            }
            c.Venta.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id, Venta item)
        {
            var resp = c.Venta.Find(id);
            if (resp == null)
            {
                return false;
            }
            resp.fecha = item.fecha;
            resp.id_cliente = item.id_cliente;
            resp.id_empleado = item.id_empleado;
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