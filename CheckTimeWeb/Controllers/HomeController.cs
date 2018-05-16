using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CheckTime.BLL;
//using CheckTime.DAL;
//using CheckTime.ENTITY;


namespace CheckTimeWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public JsonResult getUsuarios()
        {
            var user = UsuarioBLL.getUsuarios();
            return Json(user,JsonRequestBehavior.AllowGet);
        }
    }
}
