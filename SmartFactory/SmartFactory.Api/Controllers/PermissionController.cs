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
    public class PermissionController : Controller
    {
        public IPermissionServices  permissionServices { get; set; }
        // GET: Permission
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [Route("GetPermissions")]
        [HttpGet]
        public List<Permission> GetPermissions()
        {
            var permissionsList = permissionServices.GetPermissions();
            return permissionsList;
        }
    }
}