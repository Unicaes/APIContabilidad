using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Api.Repository
{
    public class RDetalle_Compra:IDetalle_Compra
    {
        private Model1 c = new Model1();
        public bool Delete(int id)
        {
            var resp = c.Detalle_Compra.Find(id);
            if (resp == null)
            {
                return false;
            }
            c.Detalle_Compra.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public IEnumerable<Detalle_Compra> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                var items = db.Detalle_Compra.Include(d=>d.Producto).Include(d=>d.Compra).ToList();
                return items;
            }
        }

        public Detalle_Compra GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            var item = c.Detalle_Compra.Find(id);
            return c.Detalle_Compra.Find(id);
        }

        public Detalle_Compra Post(Detalle_Compra item)
        {
            if (item == null)
            {
                return null;
            }
            c.Detalle_Compra.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id, Detalle_Compra item)
        {
            var resp = c.Detalle_Compra.Find(id);
            if (resp == null)
            {
                return false;
            }
            resp.cantidad = item.cantidad;
            resp.id_compra = item.id_compra;
            resp.id_producto = item.id_producto;
            resp.monto = item.monto;
            resp.precio_unitario = item.precio_unitario;
            c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
            c.SaveChanges();
            return true;
        }
    }
}