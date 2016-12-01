using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace productApi.Models
{
    public class UserLogin
    {
        [Key]
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string guid { get; set; }
        public role role { get; set; }

    }
}