using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace productApi.Models
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
     
        public int userId { get; set; }
        public int roleId { get; set; }
        public user user { get; set; }
        public role role { get; set; }
    }
}