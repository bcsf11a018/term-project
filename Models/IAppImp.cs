using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Term_Project.Models;


namespace Term_Project.Models
{
    public class IAppImp:IApp
    {
       // Database1Entities db = new Database1Entities();
        public void save(login l)
        {
            
            using (Database1Entities1 db = new Database1Entities1()) {
                db.logins.Add(l);
                db.SaveChanges();

            }     
        
        }

        public int search(login l)
        {
            using (Database1Entities1 db = new Database1Entities1())
            {
                var y = db.logins.FirstOrDefault(x=>x.username.Equals(l.username) && x.password.Equals(l.password)) ;
                //var q = from y in db.logins select y;
                if (y != null) { return 1; }
                
            }
            return 0;

        }

        //public product checkSearch(string search)
        //{
        //    Database1Entities1 db = new Database1Entities1();
        //    return db.products.FirstOrDefault(x => x.option.Equals(search));
        //    //if (u != null)
        //    //{
        //    //    result = "User Name is already exist";
        //    //}
        //    //else
        //    //{
        //    //    result = "User Name is Available";
        //    //}
        //    //return result;
        //}


        public string checkUser(string name)
        {
            Database1Entities1 db = new Database1Entities1();
            string result;
            var u = db.logins.FirstOrDefault(x=>x.username.Equals(name));
            if (u != null)
            {
                result = "User Name is already exist";
            }
            else
            {
                result = "User Name is Available";
            }
            return result;
        }


        public void submitpost(product p)
        {
            using (Database1Entities1 db = new Database1Entities1())
            {

                //if()
                db.products.Add(p);
                db.SaveChanges();
            }

        }

    }
}