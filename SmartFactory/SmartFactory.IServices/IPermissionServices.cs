using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.IServices
{
   public interface IPermissionServices
    {
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        int AddPermission(Permission permission);

        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeletePermission(int id);

        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        int UpdatePermission(Permission permission);

        /// <summary>
        /// 显示权限
        /// </summary>
        /// <returns></returns>
        List<Permission> GetPermissions();

        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Permission GetByID(int id);
    }
}
