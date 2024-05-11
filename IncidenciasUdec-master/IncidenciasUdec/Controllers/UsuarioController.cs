using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IncidenciasUdec.Models;

namespace IncidenciasUdec.Controllers
{
    public class UsuarioController : Controller
    {
        private reportesudecEntities db = new reportesudecEntities();
     
        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }
    }
}
