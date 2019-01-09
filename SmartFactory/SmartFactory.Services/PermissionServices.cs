using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{
    public class PermissionServices : IPermissionServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public int AddPermission(Permission permission)
        {
            factoryDBcontext.Permission.Add(permission);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeletePermission(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Permission> GetPermissions()
        {
            var permissionList= factoryDBcontext.Permission.ToList();
            return permissionList;
        }

        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public int UpdatePermission(Permission permission)
        {
            factoryDBcontext.Entry(permission).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 获取权限id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<Permission> IPermissionServices.GetByID(int id)
        {
            MySqlParameter[] parameters = new MySqlParameter[1]
                   {
                   new MySqlParameter("@sid", id)

                   };
            var loginList = factoryDBcontext.Database.SqlQuery<Permission>("call Pro_GetAllPermission(@sid)", parameters).ToList();
            return loginList;
        }
    }
}
