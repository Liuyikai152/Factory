using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Services
{
    using SmartFactory.Model;
    using SmartFactory.IServices;

    public class ProcessServices:IProcessServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 显示审批流程
        /// </summary>
        /// <returns></returns>
        public List<Process> GetStatus()
        {
            var getProcess = from a in factoryDBcontext.Process.ToList() select a;
            return getProcess.ToList();
        }
    }
}
