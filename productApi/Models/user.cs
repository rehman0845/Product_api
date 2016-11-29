using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace productApi.Models
{
    public class user
    {

        [Key]
        public int userId { get; set; }
        public string useremail { get; set; }
        public string password { get; set; }


    }
}