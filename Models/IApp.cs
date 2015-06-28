using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Term_Project.Models
{
   public interface IApp
    {
        void save(login l);
        int search(login l);
        void submitpost(product p);
        string checkUser(string name);
       // product checkSearch(string search);
        //string checkpage(string name);
    }
}
