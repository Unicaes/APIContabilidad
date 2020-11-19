using Api.Models;
using Api.Repository;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class ProveedorController : ApiController
    {
        static readonly IProveedor c = new RProveedor();
        // GET: Proveedor

        public HttpResponseMessage Post(Proveedor item)
        {
            item = c.Post(item);
            if (item == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "Los datos del Proveedor no pueden ser nulos");
            }
            return Request.CreateResponse(HttpStatusCode.Created, item);
        }
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var items = c.GetAll();
            if (items.Count() == 0)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay registros de Proveedors");
            }
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }
        public HttpResponseMessage GetById(int id)
        {
            Proveedor items = c.GetById(id);
            if (items == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun Proveedor con el id " + id);
            }
            return Request.CreateResponse(HttpStatusCode.OK, items);
        }
        public HttpResponseMessage Delete(int id)
        {
            var item = c.GetById(id);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun Proveedor con el id " + id + " para eliminar");
            }
            c.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "El registro ha sido eliminado");
        }
        //Metodo Put
        public HttpResponseMessage Put(int id, Proveedor Proveedor)
        {
            var item = c.GetById(id);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun Proveedor con el id " + id + " para actualizar");
            }
            var isPut = c.Put(id, Proveedor);
            if (!isPut)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotModified, "No ha sido posible la actualizacion");
            }
            return Request.CreateResponse(HttpStatusCode.OK, "El registro ha sido actualizado");
        }
    }
}