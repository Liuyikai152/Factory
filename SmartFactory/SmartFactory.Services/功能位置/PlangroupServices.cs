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
    /// 计划员组实现类
    /// </summary>
    public class PlangroupServices : IPlangroupServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 显示所有计划员组
        /// </summary>
        /// <returns></returns>
        public List<Plangroup> GetPlangroups()
        {
            var plangroupList = factoryDBcontext.Database.SqlQuery<Plangroup>("").ToList();
            return plangroupList;
        }
    }
}
