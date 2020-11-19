using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repository
{
    public class RInventario:IInventario
    {
        private Model1 c = new Model1();
        public bool Delete(int id)
        {
            var resp = c.Inventario.Find(id);
            if (resp == null)
            {
                return false;
            }
            c.Inventario.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public IEnumerable<Inventario> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Inventario.ToList();
            }
        }

        public Inventario GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            return c.Inventario.Find(id);
        }

        public Inventario Post(Inventario item)
        {
            if (item == null)
            {
                return null;
            }
            c.Inventario.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id, Inventario item)
        {
            var resp = c.Inventario.Find(id);
            if (resp == null)
            {
                return false;
            }
            resp.cantidad = item.cantidad;
            resp.costo = item.costo;
            resp.fecha_entrada = item.fecha_entrada;
            resp.id_detalle_compra = item.id_detalle_compra;
            resp.id_producto = item.id_producto;
            resp.lote = item.lote;
            resp.precio = item.precio;
            c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
            c.SaveChanges();
            return true;
        }
    }
}