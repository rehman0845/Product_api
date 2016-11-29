using productApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace productApi.Controllers
{
    public class AccountController : ApiController
    {
        Models.UserContext re = null;
        public AccountController()
        {
            re = new UserContext();
        }

        [HttpPost]
        public IHttpActionResult Login(UserLogin login)
        {

            re.UserLogins.Add(login);

            return Ok();
        }

        
        [HttpPost]
        [Route("api/Account/Register")]
        public IHttpActionResult Register(user user)
        {
            user.userId = 1;
            re.users.Add(user);
            return Ok();
        }
        
    }
}
