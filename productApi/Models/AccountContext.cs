using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace productApi.Models
{
    public class AccountContext:DbContext
    {
        public AccountContext()
            : base("rehman")
        {

        }

        public DbSet<role> roles { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
    }
}