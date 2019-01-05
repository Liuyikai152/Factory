using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartFactory.IServices;
using SmartFactory.Model;
using SmartFactory.Services;

namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("Users")]
    public class UsersController : ApiController
    {

        public IUsersServices userservices { get; set; }

        [Route("UsersAdd")]
        [HttpPost]
        public int UsersAdd(Users user)
        {
            int i= userservices.AddUsers(user);
            return i;
        }
    }
}
