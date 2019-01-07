using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.Model;
using SmartFactory.IServices;

namespace SmartFactory.Services
{
    public class UsersServices : IUsersServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddUsers(Users user)
        {
            factoryDBcontext.Users.Add(user);
            return factoryDBcontext.SaveChanges();

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteUsers(int id)
        {
            factoryDBcontext.Users.Remove(GetByID(id));
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 查询ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Users GetByID(int id)
        {
           var i= factoryDBcontext.Users.Find(id);
            return i;
        }

        /// <summary>
        /// 获取权限路径
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Users> GetPermissiomUrl(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Users> GetUsers()
        {
            var userList= factoryDBcontext.Database.SqlQuery<Users>("call Pro_GetUsers").ToList();
            return userList;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public int Login(string userName, string passWord)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UpdateUsers(Users user)
        {
            factoryDBcontext.Entry(user).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }
    }
}
