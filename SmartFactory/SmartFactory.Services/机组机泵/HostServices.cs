using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.IServices;
using SmartFactory.Model;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace SmartFactory.Services
{
    public class HostServices : IHostServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加机组
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public int AddHost(Host host)
        {
            factoryDBcontext.Host.Add(host);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 删除主机/附机
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteHost(int id)
        {
            factoryDBcontext.Host.Remove(GetByID(id));
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 获取单个id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Host GetByID(int id)
        {
            var i = factoryDBcontext.Host.Find(id);
            return i;
        }

       /// <summary>
       /// 查询所有主机/附机
       /// </summary>
       /// <returns></returns>
        public List<Host> GetHost(string PNumber)
        {
           
            var hostList = factoryDBcontext.Database.SqlQuery<Host>("call Pro_GetHostList(@PNumber)",new MySqlParameter("@PNumber", PNumber)).ToList();
            return hostList;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        public int UpdateHost(Host host)
        {
            factoryDBcontext.Entry(host).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 显示机组主机/附机列表
        /// </summary>
        /// <param name="PNumber"></param>
        /// <returns></returns>
        public List<Host> GetUnitHost(string uNumber)
        {

            var hostList = factoryDBcontext.Database.SqlQuery<Host>("CALL Pro_GetUnitHost(@uNumber)", new MySqlParameter("@uNumber", uNumber)).ToList();
            return hostList;
        }
    }
}
