using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;

    /// <summary>
    /// 审批流程接口
    /// </summary>
    public interface IProcess
    {
        /// <summary>
        /// 显示审批流程
        /// </summary>
        /// <returns></returns>
        List<Process> GetStatus();
    }
}
