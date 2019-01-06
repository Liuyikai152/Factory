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
    /// 审批状态实现类
    /// </summary>
    public class StatusServices:IStatusServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 显示审批状态
        /// </summary>
        /// <returns></returns>
        public List<Status> GetStatus()
        {
            var getStatus = from a in factoryDBcontext.Status.ToList() select a;
            return getStatus.ToList();
        }

    }
}
