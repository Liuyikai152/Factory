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
        public List<Roles> GetRoles()
        {
            var roleList = roleServices.GetRoles();
            return roleList;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [Route("AddRole")]
        [HttpPost]
        public int AddRole(string roleName, string pId)
        {
            Role role = new Role();
            role.RoleName = roleName;
            role.Pid = pId;
            var result = roleServices.AddRole(role);
            return result;
        }

        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetByID")]
        [HttpGet]
        public List<Role> GetByID(int id)
        {
            var roleList = roleServices.GetByID(id);
            return roleList;
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [Route("UpdateRole")]
        [HttpPost]
        public int UpdateRole(string roleName, string pId, int id)
        {
            Role role = new Role();
            role.RoleName = roleName;
            role.Pid = pId;
            role.ID = id;
            var result = roleServices.UpdateRole(role);
            return result;
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DeleteRole")]
        [HttpGet]
        public int DeleteRole(int id)
        {
            var result = roleServices.DeleteRole(id);
            return result;
        }
    }
}