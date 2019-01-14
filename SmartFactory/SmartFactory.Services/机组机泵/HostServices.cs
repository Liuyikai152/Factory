using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.IServices;
using SmartFactory.Model;

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

        public List<Host> GetHost()
        {
            var hostList = factoryDBcontext.Host.ToList();
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
    }
}
