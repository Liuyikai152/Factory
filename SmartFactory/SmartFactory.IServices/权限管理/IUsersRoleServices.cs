using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.IServices
{
   public interface IUsersRoleServices
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="usersRole"></param>
        /// <returns></returns>
        int AddUserRole(UsersRole  usersRole);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteUserRole(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="usersRole"></param>
        /// <returns></returns>
        int UpdateUserRole(UsersRole usersRole);

        /// <summary>
        /// 查看
        /// </summary>
        /// <returns></returns>
        List<UsersRole> GetUsersRoles();
    }
}
