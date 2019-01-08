using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using SmartFactory.IServices;
using SmartFactory.Model;
using SmartFactory.Services;

namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("Role")]
    public class RoleController : Controller
    {
        public IRoleServices  roleServices { get; set; }
        // GET: Role
        public ActionResult Index()
        {
            return View();
        }


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