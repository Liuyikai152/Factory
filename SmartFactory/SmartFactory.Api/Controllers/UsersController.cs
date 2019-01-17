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
        public List<UserInfo> GetUsers()
        {
            var userList = usersServices.GetUsers();
            return userList;
        }

        /// <summary>
        /// 显示审批人
        /// </summary>
        /// <returns></returns>
        [Route("GetApprovalUsers")]
        [HttpGet]
        public List<Users> GetApprovalUsers()
        {
            var userList = usersServices.GetApprovalUsers();
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

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="t_Users"></param>
        /// <returns></returns>
        [Route("AddUsers")]
        [HttpPost]
        public int AddUsers(string userName, string passWord, string roleId)
        {
            Users users = new Users();
            users.UserName = userName;
            users.PassWord = passWord;
            users.RoleId = roleId;
            var result = usersServices.AddUsers(users);
            return result;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [Route("DeleteUsers")]
        [HttpGet]
        public int DeleteUsers(int ID)
        {
            var result = usersServices.DeleteUsers(ID);
            return result;
        }


        /// <summary>
        /// 获取角色id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetByID")]
        [HttpGet]
        public List<Users> GetByID(int id)
        {
            var result = usersServices.GetByID(id);
            return result;
        }

        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="Users"></param>
        /// <returns></returns>
        [Route("UpdateUsers")]
        [HttpPost]
        public int UpdateUsers(string userName, string passWord, string roleId, int id)
        {
            Users users = new Users();
            users.UserName = userName;
            users.PassWord = passWord;
            users.RoleId = roleId;
            users.ID = id;
            var result = usersServices.UpdateUsers(users);
            return result;
        }


        /// <summary>
        /// 获取权限路径
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetPermissiomUrl")]
        [HttpGet]      
        public List<UserInfo> GetPermissiomUrl(int id)
        {
            var result = usersServices.GetPermissiomUrl(id);
            return result;
        }
    }
}
