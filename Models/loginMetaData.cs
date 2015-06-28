using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Term_Project.Models
{
    public class loginMetaData
    {

        // public int Id { get; set; }
        [Required]
        public string username { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Required]
        public string password { get; set; }

    }
       
}