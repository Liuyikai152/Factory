using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{
    public class PermissionRoleServices : IPermissionRoleServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="permissionRole"></param>
        /// <returns></returns>
        public int AddRolePermission(PermissionRole permissionRole)
        {
            factoryDBcontext.PermissionRole.Add(permissionRole);
            return factoryDBcontext.SaveChanges();
        }

        public int DeleteRolePermission(int id)
        {
            var i = factoryDBcontext.PermissionRole.Find(id);
            factoryDBcontext.PermissionRole.Remove(i);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<PermissionRole> GetPermissionRoles()
        {
            return factoryDBcontext.PermissionRole.ToList();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="permissionRole"></param>
        /// <returns></returns>
        public int UpdateRolePermission(PermissionRole permissionRole)
        {
            factoryDBcontext.Entry(permissionRole).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }
    }
    }

