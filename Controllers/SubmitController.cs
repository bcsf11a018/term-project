using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Term_Project.Models;

namespace Term_Project.Controllers
{
    public class SubmitController : Controller
    {
        //
        // GET: /Submit/
        Database1Entities1 db = new Database1Entities1();

        IApp obj;
        public SubmitController(IApp i) {
            obj = i;
        }

        public ActionResult post()
        {
            return View();
        }

        [HttpPost]
        public ActionResult postinfo(product p)
        {
            HttpPostedFileBase file = Request.Files["file"];

            string ImageName = System.IO.Path.GetFileName(file.FileName);
            string physicalPath = Server.MapPath(@"~\pics\" + ImageName);
          
            // save image in folder
            file.SaveAs(physicalPath);

            //save new record in database

            p.file = "/pics/" +ImageName;
            obj.submitpost(p);
         
            //db.products.Add(p);
            //db.SaveChanges();

            return RedirectToAction("post");

            //ob.submitpost(p);
            //return RedirectToAction("index");
            //db.products.Attach(p);
            //db.products.Add(p);
            //db.SaveChanges();

            //return View(db.products.ToList());

        }

       
        public ActionResult signin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult signininfo(login log)
        {
          int i = obj.search(log);
          if (i == 1) { return RedirectToAction("post"); }


          return View("signin");
            //var q = from y in db.logins select y;
            //foreach (var x in q)
            //{
            //    if (x.username == log.username && x.password == log.password)
            //    {
            //        return RedirectToAction("post");

            //    }
            //}a

            
        }
    }
}
