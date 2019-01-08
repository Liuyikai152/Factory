using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// 获取权限id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Permission GetByID(int id)
        {
            var i= factoryDBcontext.Permission.Find(id);
            return i;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Permission> GetPermissions()
        {
            var permissionList = factoryDBcontext.Database.SqlQuery<Permission>("call Pro_Getpermission").ToList();
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
    }
}
