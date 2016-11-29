using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace productApi.Models
{
    class UserContext:DbContext
    {
        public UserContext():base("rehman")
        {
        
        }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<role> roles { get; set; }
        public DbSet<user> users { get; set; }
    }
}