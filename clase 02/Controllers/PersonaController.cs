using clase_02.DAORE;
using clase_02.Models;
using clase_02.Models.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clase_02.Controllers
{
    public class PersonaController : Controller
    {
        //public ActionResult DescripcionPernsonaViewModel(PersonaWiewModels)        {
        //    return View();
        //}

        
        public ActionResult Descripcion(String variable)
        {
            ViewBag.variabledinamica = variable;

            //var per = new ClsPersona { Nombre = "Roberto" };
            // return View(per);

            PersonaRepository per = new PersonaRepository();

            
            return View(per.ObtenerPersona());

        }

       
    }
}