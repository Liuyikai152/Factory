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
    [RoutePrefix("Role")]
    public class RoleController : ApiController
    {
        public IRoleServices  roleServices { get; set; }
        // GET: Role
  


        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [Route("GetRoles")]
        [HttpGet]
        public List<Role> GetRoles()
        {
            var userList = roleServices.GetRoles();
            return userList;
        }
    }
}