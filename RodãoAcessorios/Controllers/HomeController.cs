using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RodãoAcessorios.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
     

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Contato()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Lataria()
        {
            return View();
        }
    public ActionResult Parabrisa()
    {
        return View();
    }
        public ActionResult Escapamentos()
    {
        return View();
    }
      public ActionResult Comprar()
        {
            return View();
        }
      public ActionResult Form()

      {
          return View();
      }
   
    }
    }