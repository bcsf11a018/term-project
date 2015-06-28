using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Term_Project.Models;

namespace Term_Project.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //Database1Entities1 db = new Database1Entities1();
        IApp obj;
        public HomeController(IApp i) {
            obj = i;
        }

        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult search()
        //{
        //    return View();
        //}

        //public JsonResult CheckSearch(string search)
        //{
        //    var result = obj.checkSearch(search);
        //    return this.Json(result, JsonRequestBehavior.AllowGet);

        //}

        public ActionResult aboutus()
        {
            return View();
        }

        public ActionResult contactus()
        {
            return View();
        }

        public ActionResult signup()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult signupinfo(login u)
        {
            obj.save(u);
            return RedirectToAction("index");
        }


        public JsonResult CheckUserName(string UserName)
        {

            //string userName = Request["username"];

            //check from database

            // List<Student> list = new List<Student>();
            //var q =  from x in db.logins where x.username.Equals(userName) select x;
            string result = obj.checkUser(UserName);
            return this.Json(result, JsonRequestBehavior.AllowGet);

        }
    }
}
