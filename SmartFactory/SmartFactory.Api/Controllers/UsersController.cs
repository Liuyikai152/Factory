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

        public IUsersServices usersServices { get; set; }


        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [Route("GetUsers")]
        [HttpGet]
        public List<Users> GetUsers()
        {
            var userList = usersServices.GetUsers();
            return userList;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        [Route("Login")]
        [HttpGet]
        public int Login(string userName, string passWord)
        {
            int result = usersServices.Login(userName, passWord);
            return result;
        }
    }
}
