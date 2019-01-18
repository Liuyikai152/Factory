using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.IServices
{
    public interface IPermissionRoleServices
    {
        /// <summary>
        /// 添加
        /// </summary> 
        /// <param name="permissionRole"></param>
        /// <returns></returns>
        int AddRolePermission(PermissionRole  permissionRole);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteRolePermission(int id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="permissionRole"></param>
        /// <returns></returns>
        int UpdateRolePermission(PermissionRole permissionRole);

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<PermissionRole> GetPermissionRoles();
    }
}
