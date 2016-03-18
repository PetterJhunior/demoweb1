using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelo.c2_aplicacion;
namespace WEBDEMO1.Controllers
{
    public class ProductoController : Controller
    {
        GestionarProductoServicio gestionarProductoServicio= new GestionarProductoServicio();
        public ActionResult Index()
        {
            return View(gestionarProductoServicio.buscarProducto());
        }
    }
}