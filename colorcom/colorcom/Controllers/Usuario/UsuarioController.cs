using colorcom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace colorcom.Controllers.Usuario
{
    public class UsuarioController : Controller
    {
        public UsuarioController()
        {
            _context = new colorcomContext();
        }

        private colorcomContext db = new colorcomContext();

        private colorcomContext _context;

        // GET: Usuario
        public ActionResult Index()
        {
            var usuarios = _context.usuarios.ToList();
            return View(usuarios);
        }
    }
}