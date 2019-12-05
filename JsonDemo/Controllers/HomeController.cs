using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult EmpDetails()
        {
            Models.Employee empmod = new Models.Employee();

            List<Models.Employee> ObjEmp = empmod.DeserializeJson();

            //return list as Json
            return Json(ObjEmp, JsonRequestBehavior.AllowGet);
        }


    }
}