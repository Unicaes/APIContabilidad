using Api.Models;
using Api.Repository;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Api.Controllers
{
    public class VentaController : ApiController
    {
        static readonly IVenta c = new RVenta();
        // GET: Venta

        public HttpResponseMessage Post(Venta item)
        {
            item = c.Post(item);
            if (item == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "Los datos del Venta no pueden ser nulos");
            }
            return Request.CreateResponse(HttpStatusCode.Created, item);
        }
        public HttpResponseMessage GetAll()
        {
            var items = c.GetAll();
            if (items.Count() == 0)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay registros de Ventas");
            }
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }
        public HttpResponseMessage GetById(int id)
        {
            Venta items = c.GetById(id);
            if (items == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun Venta con el id " + id);
            }
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }
        public HttpResponseMessage Delete(int id)
        {
            var item = c.GetById(id);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun Venta con el id " + id + " para eliminar");
            }
            c.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "El registro ha sido eliminado");
        }
        //Metodo Put
        public HttpResponseMessage Put(int id, Venta Venta)
        {
            var item = c.GetById(id);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun Venta con el id " + id + " para actualizar");
            }
            var isPut = c.Put(id, Venta);
            if (!isPut)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotModified, "No ha sido posible la actualizacion");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "El registro ha sido actualizado");
        }
    }
}