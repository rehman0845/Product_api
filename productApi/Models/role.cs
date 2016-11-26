using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace productApi.Models
{
    public class role
    {
        [Key]
        public int Id { get; set; }
        public string roleName { get; set; }
    }
}