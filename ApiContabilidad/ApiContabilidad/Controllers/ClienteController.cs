using ApiContabilidad.Models;
using ApiContabilidad.Repository;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiContabilidad.Controllers
{
    public class ClienteController : Controller
    {
        static readonly ICliente c = new RCliente();
        HttpRequestMessage request = new HttpRequestMessage();
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
        public HttpResponseMessage Post(Cliente item)
        {
            item = c.Post(item);
            if (item==null)
            {
                return request.CreateErrorResponse(HttpStatusCode.NotAcceptable, "Los datos del cliente no pueden ser nulos");
            }
            return request.CreateResponse(HttpStatusCode.Created, item);
        }
        public HttpResponseMessage GetAll()
        {
            var items = c.GetAll();
            if (items.Count() == 0)
            {
                //Construyendo respuesta del servidor
                return request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay registros de clientes");
            }
            return request.CreateResponse(HttpStatusCode.OK, items);
        }
        public HttpResponseMessage GetById(int id)
        {
            Cliente items = c.GetById(id);
            if (items == null)
            {
                //Construyendo respuesta del servidor
                return request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun cliente con el id " + id);
            }
            return request.CreateResponse(HttpStatusCode.OK, items);
        }
        public HttpResponseMessage Delete(int id)
        {
            var item = c.GetById(id);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun cliente con el id " + id + " para eliminar");
            }
            c.Delete(id);
            return request.CreateResponse(HttpStatusCode.OK, "El registro ha sido eliminado");
        }
        //Metodo Put
        public HttpResponseMessage Put(int id, Cliente cliente)
        {
            var item = c.GetById(id);
            if (item == null)
            {
                //Construyendo respuesta del servidor
                return request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay ningun cliente con el id " + id + " para actualizar");
            }
            var isPut = c.Put(id, cliente);
            if (!isPut)
            {
                return request.CreateErrorResponse(HttpStatusCode.NotModified, "No ha sido posible la actualizacion");
            }
            return request.CreateResponse(HttpStatusCode.OK, "El registro ha sido actualizado");
        }
    }
}