using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace productApi.Models
{
    public class UserRole
    {
        public UserLogin userId { get; set; }
        public role roleId { get; set; }
    }
}