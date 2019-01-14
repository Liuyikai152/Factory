using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{
    /// <summary>
    /// 维护班组类
    /// </summary>
    public class ServiceGroupServices:IServiceGroupServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 查看维护班组
        /// </summary>
        /// <returns></returns>
        public List<ServiceGroup> GetServiceGroups()
        {
            var serviceGroupList = factoryDBcontext.Database.SqlQuery<ServiceGroup>("").ToList();
            return serviceGroupList;
        }
    }
}
