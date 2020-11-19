using Api.Models;
using Api.Repository;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class Detalle_VentaController : ApiController
    {
       static readonly IDetalle_Venta c = new RDetalle_Venta();
        // GET: Detalle_Venta
        
        public HttpResponseMessage Post(Detalle_Venta item)
        {
            item = c.Post(item);
            if (item == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "Los datos del Detalle_Venta no pueden ser nulos");
            }
            return Request.CreateResponse(HttpStatusCode.Created, item);
        }
        public HttpResponseMessage GetAll()
        {
            var items = c.GetAll();
            if (items.Count() == 0)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay registros de Detalle_Ventas");
            }
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }
        public HttpResponseMessage GetById(int id)
        {
            Detalle_Venta items = c.GetById(id);
            if (items == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun Detalle_Venta con el id " + id);
            }
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }
        public HttpResponseMessage Delete(int id)
        {
            var item = c.GetById(id);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun Detalle_Venta con el id " + id + " para eliminar");
            }
            c.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "El registro ha sido eliminado");
        }
        //Metodo Put
        public HttpResponseMessage Put(int id, Detalle_Venta Detalle_Venta)
        {
            var item = c.GetById(id);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun Detalle_Venta con el id " + id + " para actualizar");
            }
            var isPut = c.Put(id, Detalle_Venta);
            if (!isPut)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotModified, "No ha sido posible la actualizacion");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "El registro ha sido actualizado");
        }
    }
}