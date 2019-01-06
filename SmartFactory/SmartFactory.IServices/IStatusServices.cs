using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;

    /// <summary>
    /// 审批状态接口
    /// </summary>
   public interface IStatusServices
    {
        /// <summary>
        /// 显示审批状态
        /// </summary>
        /// <returns></returns>
        List<Status> GetStatus();
    }
}
