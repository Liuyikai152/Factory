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
    public class RoleServices : IRoleServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int AddRole(Role role)
        {
            MySqlParameter[] parameters = new MySqlParameter[]
                  {
                   new MySqlParameter("@rname", role.RoleName)

                  };
            var roleList = factoryDBcontext.Database.SqlQuery<Role>("CALL Pro_GetRoleName(@rname)", parameters).ToList();
            int result = -1;
            if (roleList.Count() == 0)
            {
                MySqlParameter[] parameters1 = new MySqlParameter[2]
                 {
                   new MySqlParameter("@rname", role.RoleName),

                   new MySqlParameter("@pids", role.Pid)
                 };

                int result2 = factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_AddRole (@rname,@pids)", parameters1);

                var ids = factoryDBcontext.Database.SqlQuery<Role>("CALL Pro_GetRoleName(@rname)", parameters).FirstOrDefault();

                var roles = role.Pid.Split(',');

                for (int i = 0; i < roles.Length; i++)
                {
                    PermissionRole permissionRole = new PermissionRole();
                    permissionRole.RoleId = ids.ID;
                    permissionRole.PermissionId = Convert.ToInt32(roles[i]);

                    MySqlParameter[] parameters2 = new MySqlParameter[2]
                   {
                   new MySqlParameter("@roleids", permissionRole.RoleId),
                   new MySqlParameter("@permissids", permissionRole.PermissionId)
                   };
                    result = factoryDBcontext.Database.ExecuteSqlCommand("Call Pro_Addpermissionrole(@roleids,@permissids)", parameters2);
                }

            }

            return result;
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteRole(int id)
        {
            MySqlParameter[] parameter = new MySqlParameter[1]
                    {
                   new MySqlParameter("@roleids", id)

                    };
           factoryDBcontext.Database.ExecuteSqlCommand("call Pro_Delpermissionrole(@roleids)", parameter);
            
            MySqlParameter[] parameters = new MySqlParameter[1]
                    {
                   new MySqlParameter("@ids", id)

                    };
            var result = factoryDBcontext.Database.ExecuteSqlCommand("call Pro_DelRole(@ids)", parameters);
            return result;
        }

        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Role> GetByID(int id)
        {
            MySqlParameter[] parameters = new MySqlParameter[1]
                  {
                   new MySqlParameter("@rid", id)

                  };
            var roleList = factoryDBcontext.Database.SqlQuery<Role>("call Pro_GetAllRole(@rid)", parameters).ToList();
            return roleList;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Roles> GetRoles()
        {
            var roleList = factoryDBcontext.Database.SqlQuery<Roles>("call Pro_GetRole()").ToList();
            return roleList;
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int UpdateRole(Role role)
        {
            MySqlParameter[] parameters = new MySqlParameter[]
                  {
                   new MySqlParameter("@rname", role.RoleName)

                  };
            var roleList = factoryDBcontext.Database.SqlQuery<Role>("CALL Pro_GetRoleName(@rname)", parameters).ToList();
            int result = -1;
            if (roleList.Count()==0|| roleList.Count() == 1)
            {
                MySqlParameter[] parameters1 = new MySqlParameter[3]
                 {
                   new MySqlParameter("@ids", role.ID),
                    new MySqlParameter("@rname", role.RoleName),
                     new MySqlParameter("@Pids", role.Pid)

                 };
                int result1 = factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_updateRole(@ids,@rname,@Pids)", parameters1);

                MySqlParameter[] parameters2 = new MySqlParameter[1]
                 {
                   new MySqlParameter("@roleids", role.ID)
                 };
                 factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_Delpermissionrole(@roleids)", parameters2);

                var roles = role.Pid.Split(',');

                for (int i = 0; i < roles.Length; i++)
                {
                    PermissionRole permissionRole = new PermissionRole();
                    permissionRole.RoleId = role.ID;
                    permissionRole.PermissionId = Convert.ToInt32(roles[i]);

                    MySqlParameter[] parameters3 = new MySqlParameter[2]
                 {
                   new MySqlParameter("@roleids", permissionRole.RoleId),
                   new MySqlParameter("@permissids", permissionRole.PermissionId)
                 };
                    result = factoryDBcontext.Database.ExecuteSqlCommand("Call Pro_Addpermissionrole(@roleids,@permissids)", parameters3);
                }
            }

            return result;
        }

    }
}
