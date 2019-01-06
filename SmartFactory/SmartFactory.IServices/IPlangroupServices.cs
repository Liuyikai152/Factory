using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SmartFactory.Model;

namespace SmartFactory.IServices
{
    /// <summary>
    /// 计划员组接口
    /// </summary>
    public interface IPlangroupServices
    {
        /// <summary>
        /// 显示所有的计划员组
        /// </summary>
        /// <returns></returns>
        List<Plangroup> GetPlangroups();
    }
}
