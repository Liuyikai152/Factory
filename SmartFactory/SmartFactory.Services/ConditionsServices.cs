using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Services
{
    using SmartFactory.Model;
    using SmartFactory.IServices;

    /// <summary>
    /// 审批条件实现类
    /// </summary>
    public class ConditionsServices:IConditions
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 显示审批条件
        /// </summary>
        /// <returns></returns>
        public List<Conditions> GetConditions()
        {
            var getConditions = from a in factoryDBcontext.Conditions.ToList() select a;
            return getConditions.ToList();
        }
    }
}
