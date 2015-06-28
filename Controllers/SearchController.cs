using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Term_Project.Models;

namespace Term_Project.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/

        Database1Entities1 db = new Database1Entities1();

        //IApp obj;
        //public SearchController(IApp i) {
        //    obj = i;
        //}

        public ActionResult search()
        {
            return View();
        }
        public ActionResult mobile()
        {
             ViewBag.x = "Mobile";
            //string s=db.products.ToList().First().file;
            return View(db.products.ToList());
        }

        public ActionResult laptops()
        {
            ViewBag.x = "Laptops";
            //string s=db.products.ToList().First().file;
            return View(db.products.ToList());
        }

        public ActionResult tablets()
        {
            ViewBag.x = "Tablets";
            //string s=db.products.ToList().First().file;
            return View(db.products.ToList());
        }

        //public JsonResult Checkpage(string pageName)
        //{

        //    //string userName = Request["username"];

        //    //check from database

        //    // List<Student> list = new List<Student>();
        //    //var q =  from x in db.logins where x.username.Equals(userName) select x;
        //    string result = obj.checkpage(pageName);
        //    return this.Json(result, JsonRequestBehavior.AllowGet);

        //}

    }
}
