﻿using System;
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
    [RoutePrefix("Permission")]
    public class PermissionController : ApiController
    {

        public IPermissionServices  permissionServices { get; set; }


        // GET: Permission


        /// <summary>
        /// 显示权限
        /// </summary>
        /// <returns></returns>
        [Route("GetPermission")]
        [HttpGet]
        public List<Permission> GetPermission()
        {
            var permissionsList = permissionServices.GetPermissions();
            return permissionsList;
        }


        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        [Route("AddPermission")]
        [HttpPost]
        public int AddPermission(Permission permission)
        {
            var result= permissionServices.AddPermission(permission);
            return result;
        }

        /// <summary>
        /// 获取权限id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetByID")]
        [HttpGet]
        public Permission GetByID(int id)
        {
            var result = permissionServices.GetByID(id);
            return result;
        }

        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        [Route("UpdatePermission")]
        [HttpPost]
        public int UpdatePermission(Permission permission)
        {
            var result = permissionServices.UpdatePermission(permission);
            return result;
        }
    }
}