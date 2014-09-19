using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RodãoAcessorios.Controllers
{
    public class PaginasDeProdutosController : Controller
    {
        //
        // GET: /PaginasDeProdutos/
        public ActionResult  FarolDeMilha()
        {
            return View();
        }
        public ActionResult FarolDeXenon()
        {
            return View();
        }
	}
}