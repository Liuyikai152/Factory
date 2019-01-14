using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.Model;
using SmartFactory.IServices;

namespace SmartFactory.Services
{
    /// <summary>
    /// 设备业务实现类
    /// </summary>
    public class BusinesServices : IBusinesServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 查看设备业务
        /// </summary>
        /// <returns></returns>
        public List<Business> GetBusinesses()
        {
            var businessList = factoryDBcontext.Database.SqlQuery<Business>("").ToList();
            return businessList;
        }
    }
}
