using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoMVC.Models;

namespace ProyectoMVC.Controllers
{
    public class EmpleadosController : Controller
    {
        BD_Neptuno entidad = new BD_Neptuno();

        // GET: Empleados
        public ActionResult GetEmpleados()
        {
            var listaEmpleados = entidad.Empleados;

            return View(listaEmpleados.ToList());
        }

        [HttpPost]
        public ActionResult GuardarEmpleado()
        {
            return View();
        }

        public ActionResult BuscarEmpleadosPorId(int idEmpleado)
        {
            var lista = from item in entidad.Empleados where item.IdEmpleado == idEmpleado select item;

            return View(lista.ToList());
        }
    }
}