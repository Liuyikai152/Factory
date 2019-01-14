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
    /// 工厂实现类
    /// </summary>
    public class PlanfactoryServices : IPlanfactoryServices
    {

        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();


        /// <summary>
        /// 查看工厂
        /// </summary>
        /// <returns></returns>
        public List<Planfactory> GetPlanfactories()
        {

            var planFactoryList = factoryDBcontext.Database.SqlQuery<Planfactory>("").ToList();
            return planFactoryList;
        }
    }
}
