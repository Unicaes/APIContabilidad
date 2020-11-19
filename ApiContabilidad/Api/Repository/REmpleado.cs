using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Repository
{
    public class REmpleado:IEmpleado
    {
        private Model1 c = new Model1();
        public bool Delete(int id)
        {
            var resp = c.Empleado.Find(id);
            if (resp == null)
            {
                return false;
            }
            c.Empleado.Remove(resp);
            c.SaveChanges();
            return true;
        }

        public IEnumerable<Empleado> GetAll()
        {
            using (var db = new Model1())
            {
                db.Configuration.ProxyCreationEnabled = false;
                return db.Empleado.ToList();
            }
        }

        public Empleado GetById(int id)
        {
            c.Configuration.ProxyCreationEnabled = false;
            return c.Empleado.Find(id);
        }

        public Empleado Post(Empleado item)
        {
            if (item == null)
            {
                return null;
            }
            c.Empleado.Add(item);
            c.SaveChanges();
            return item;
        }

        public bool Put(int id, Empleado item)
        {
            var resp = c.Empleado.Find(id);
            if (resp == null)
            {
                return false;
            }
            resp.apellido = item.apellido;
            resp.nombre = item.nombre;
            resp.telefono = item.telefono;
            c.Entry(resp).State = System.Data.Entity.EntityState.Modified;
            c.SaveChanges();
            return true;
        }
    }
}