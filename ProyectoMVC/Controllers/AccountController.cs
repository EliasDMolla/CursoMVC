using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoMVC.Models;

namespace ProyectoMVC.Controllers
{
    public class AccountController : Controller
    {
        BD_Neptuno entidad = new BD_Neptuno();

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
    }
}