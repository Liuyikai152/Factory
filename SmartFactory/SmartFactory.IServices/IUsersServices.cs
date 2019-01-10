
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SmartFactory.Model;

namespace SmartFactory.IServices
{
    public interface IUsersServices
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="t_Users"></param>
        /// <returns></returns>
        int AddUsers(Users user);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteUsers(int id);

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="t_Users"></param>
        /// <returns></returns>
        int UpdateUsers(Users user);

        /// <summary>
        /// 查看
        /// </summary>
        /// <returns></returns>
        List<Users> GetUsers();
        List<UserInfo> GetUsers();

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        int Login(string userName, string passWord);

        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Users GetByID(int id);

        List<Users> GetPermissiomUrl(int id);

    }
}
