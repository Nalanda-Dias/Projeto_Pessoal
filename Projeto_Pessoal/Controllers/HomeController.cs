using Projeto_Pessoal.Funcoes;
using Projeto_Pessoal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto_Pessoal.Controllers
{
    public class HomeController : Controller
    {
        ClMetas cl = new ClMetas();
        ClAcoesMetas ac = new ClAcoesMetas();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadMetas()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadMetas(ClMetas cm)
        {
            ac.InserirMetas(cm);
            return View();
        }
    }
}