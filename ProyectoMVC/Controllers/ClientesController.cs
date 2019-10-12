using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoMVC.Models;

namespace ProyectoMVC.Controllers
{
    public class ClientesController : Controller
    {
        BD_Neptuno entidad = new BD_Neptuno();

        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetClientes()
        {
            var listaClientes = entidad.clientes;

            return View(listaClientes.ToList());
        }
    }
}