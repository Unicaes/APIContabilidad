using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repository
{
    public class RDetalle_Venta:IDetalle_Venta
    {
        private Model1 c = new Model1();
        public bool Delete(int id)
        {
            var resp = c.Detalle_Venta.Find(id);
            if (resp == null)
            {
                return false;
            }
            c.Detalle_Venta.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public IEnumerable<Detalle_Venta> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Detalle_Venta.ToList();
            }
        }

        public Detalle_Venta GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            return c.Detalle_Venta.Find(id);
        }

        public Detalle_Venta Post(Detalle_Venta item)
        {
            if (item == null)
            {
                return null;
            }
            c.Detalle_Venta.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id, Detalle_Venta item)
        {
            var resp = c.Detalle_Venta.Find(id);
            if (resp == null)
            {
                return false;
            }
            resp.cantidad = item.cantidad;
            resp.id_venta = item.id_venta;
            resp.id_producto = item.id_producto;
            resp.monto = item.monto;
            resp.precio_unitario = item.precio_unitario;
            c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
            c.SaveChanges();
            return true;
        }
    }
}