using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RodãoAcessorios.Controllers
{
    public class LinksDropDownController : Controller
    {
        //
        // GET: /LinksDropDown/
        public ActionResult PaginaEscolhaMarcaFarol()
        {
            return View();
        }
        public ActionResult Xenon()
        {
            return View();
        }
        public ActionResult FarolPrincipalGol()
        {
            return View();
        }
        public ActionResult PaginaFaroDeMilha()
        {
            return View();
        }
	}
}