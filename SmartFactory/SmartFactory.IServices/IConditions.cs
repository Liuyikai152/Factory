using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;

    /// <summary>
    /// 审批条件接口
    /// </summary>
    public interface IConditions
    {
        /// <summary>
        /// 显示审批条件
        /// </summary>
        /// <returns></returns>
        List<Conditions> GetConditions();
    }
}
