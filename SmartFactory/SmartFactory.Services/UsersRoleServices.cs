using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{
    public class UsersRoleServices : IUsersRoleServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="usersRole"></param>
        /// <returns></returns>
        public int AddUserRole(UsersRole usersRole)
        {
            factoryDBcontext.UsersRole.Add(usersRole);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteUserRole(int id)
        {
            var i = factoryDBcontext.UsersRole.Find(id);
            factoryDBcontext.UsersRole.Remove(i);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<UsersRole> GetUsersRoles()
        {
            return factoryDBcontext.UsersRole.ToList();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="usersRole"></param>
        /// <returns></returns>
        public int UpdateUserRole(UsersRole usersRole)
        {
            factoryDBcontext.Entry(usersRole).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }
    }
}
