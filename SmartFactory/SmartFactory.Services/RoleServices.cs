using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{
    public class RoleServices : IRoleServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int AddRole(Role role)
        {
            factoryDBcontext.Role.Add(role);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteRole(int id)
        {
            factoryDBcontext.Role.Find(GetByID(id));
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 获取单个id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Role GetByID(int id)
        {
            var i= factoryDBcontext.Role.Find(id);
            return i;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Role> GetRoles()
        {
            var roleList= factoryDBcontext.Role.ToList();
            return roleList;
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int UpdateRole(Role role)
        {
            factoryDBcontext.Entry(role).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }
    }
}
