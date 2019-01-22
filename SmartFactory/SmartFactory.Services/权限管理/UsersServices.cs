using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.Model;
using SmartFactory.IServices;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SmartFactory.Services
{
    public class UsersServices : IUsersServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int AddUsers(Users user)
        {

            MySqlParameter[] parameters = new MySqlParameter[]
                  {
                   new MySqlParameter("@uname", user.UserName)

                  };
            var userList = factoryDBcontext.Database.SqlQuery<Users>("CALL Pro_Getusername(@uname)", parameters).ToList();
            int result = -1;
            if (userList.Count() == 0)
            {
                MySqlParameter[] parameters1 = new MySqlParameter[3]
                 {
                   new MySqlParameter("@uname", user.UserName),
                   new MySqlParameter("@pwd", user.PassWord),
                   new MySqlParameter("@roleids", user.RoleId)
                 };

                int result2 = factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_AddUsers (@uname,@pwd,@roleids)", parameters1);

                var ids = factoryDBcontext.Database.SqlQuery<Users>("CALL Pro_Getusername(@uname)", parameters).FirstOrDefault();

                var roles = user.RoleId.Split(',');

                for (int i = 0; i < roles.Length; i++)
                {
                    UsersRole usersRole = new UsersRole();
                    usersRole.UserId = ids.ID;
                    usersRole.RoleId = Convert.ToInt32(roles[i]);

                    MySqlParameter[] parameters2 = new MySqlParameter[2]
                   {
                   new MySqlParameter("@uid", usersRole.UserId),
                   new MySqlParameter("@rid", usersRole.RoleId)
                   };
                    result = factoryDBcontext.Database.ExecuteSqlCommand("Call Pro_AddUserRole(@uid,@rid)", parameters2);
                }

            }

            return result;
        }

        /// <summary>`  
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteUsers(int id)
        {
            MySqlParameter[] parameter = new MySqlParameter[1]
                    {
                   new MySqlParameter("@uid", id)

                    };
            factoryDBcontext.Database.ExecuteSqlCommand("call Pro_DeleteUsersRole(@uid)", parameter);

            MySqlParameter[] parameters = new MySqlParameter[1]
                     {
                   new MySqlParameter("@ids", id)

                     };
            var result = factoryDBcontext.Database.ExecuteSqlCommand("call Pro_DeleteUsers(@ids)", parameters);
            return result;
        }

        /// <summary>
        /// 查询ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Users> GetByID(int id)
        {
            MySqlParameter[] parameters = new MySqlParameter[1]
                 {
                   new MySqlParameter("@uid", id)

                 };
            var userList = factoryDBcontext.Database.SqlQuery<Users>("call Pro_GetAllUser(@uid)", parameters).ToList();
            return userList;
        }

        /// <summary>
        /// 审批人
        /// </summary>
        /// <returns></returns>
        public List<Users> GetApprovalUsers()
        {
            var userList = from a in factoryDBcontext.Users.ToList() select a;
            return userList.ToList();
        }

        /// <summary>
        /// 获取权限路径
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<UserInfo> GetPermissiomUrl(int id)
        {
            MySqlParameter[] parameters = new MySqlParameter[1]
                 {
                   new MySqlParameter("@ids", id)

                 };
            var userList = factoryDBcontext.Database.SqlQuery<UserInfo>("call Pro_GetPermissionUrl(@ids)", parameters).ToList();
            return userList;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<UserInfo> GetUsers()
        {
            var userList = factoryDBcontext.Database.SqlQuery<UserInfo>("call Pro_GetUsers").ToList();
            return userList;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public int Login(string userName, string passWord)
        {
            MySqlParameter[] parameters = new MySqlParameter[2]
                {
                   new MySqlParameter("@name", userName),
                   new MySqlParameter("@pwd", passWord)
                };
            var loginList = factoryDBcontext.Database.SqlQuery<Users>("call Pro_Login(@name,@pwd)", parameters).ToList();
            if (loginList.Count() > 0)
            
                return loginList[0].ID;
            
            return 0;
        }
        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UpdateUsers(Users user)
        {

            MySqlParameter[] parameters = new MySqlParameter[]
                  {
                   new MySqlParameter("@uname", user.UserName)

                  };
            var userList = factoryDBcontext.Database.SqlQuery<Users>("CALL Pro_Getusername(@uname)", parameters).ToList();
            int result = -1;
            if (userList.Count() == 0 || userList.Count() == 1)
            {
                MySqlParameter[] parameters1 = new MySqlParameter[4]
                 {
                   new MySqlParameter("@ids", user.ID),
                    new MySqlParameter("@uname", user.UserName),
                     new MySqlParameter("@pwd", user.PassWord),
                       new MySqlParameter("@rids", user.RoleId)

                 };
                int result1 = factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_UpdateUsers(@ids,@uname,@pwd,@rids)", parameters1);

                MySqlParameter[] parameters2 = new MySqlParameter[1]
                 {
                   new MySqlParameter("@uid", user.ID)
                 };
                factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_DeleteUsersRole(@uid)", parameters2);

                var users = user.RoleId.Split(',');

                for (int i = 0; i < users.Length; i++)
                {
                    UsersRole usersRole = new UsersRole();
                    usersRole.UserId = user.ID;
                    usersRole.RoleId = Convert.ToInt32(users[i]);

                    MySqlParameter[] parameters3 = new MySqlParameter[2]
                 {
                   new MySqlParameter("@uid", usersRole.UserId),
                   new MySqlParameter("@rid", usersRole.RoleId)
                 };
                    result = factoryDBcontext.Database.ExecuteSqlCommand("Call Pro_AddUsersRole(@uid,@rid)", parameters3);
                }
            }

            return result;
        }
    }
}
