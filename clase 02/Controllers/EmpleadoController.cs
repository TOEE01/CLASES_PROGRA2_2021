using clase_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clase_02.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado()
        {

            using (EMPLEADOSEntities Empleado =  new EMPLEADOSEntities())
            {
                var tbls = Empleado.tbl_empleados.ToList();

                return View(tbls);
            }
            
        }

        public ActionResult Delete(int id)
        {
            using (EMPLEADOSEntities Empleado = new EMPLEADOSEntities())
            {
                tbl_empleados ElimninarEmpleado = Empleado.tbl_empleados.Where(x => x.id_persona == id).FirstOrDefault();
                Empleado.tbl_empleados.Remove(ElimninarEmpleado);
                Empleado.SaveChanges();
                
            }
               return Redirect("/Empleado/Empleado");
        }

        public ActionResult Save()
        {
            using (EMPLEADOSEntities Empleado = new EMPLEADOSEntities())
            {
                

            }
                return ("/Registro/Registro");
        }
    }
}