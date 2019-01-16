using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.Model;

namespace SmartFactory.IServices
{

    /// <summary>
    /// 审批活动接口
    /// </summary>
    public interface IActivityServices
    {
        /// <summary>
        /// 添加审批活动
        /// </summary>
        /// <param name="activity"></param>
        /// <returns></returns>
        int AddActivity(int judgment);

        /// <summary>
        /// 查看审批活动
        /// </summary>
        /// <returns></returns>
        List<ActivityNotMappit> GetActivities(string name, string state);

        /// <summary>
        ///  修改审批流程状态
        /// </summary>
        /// <param name="ActivityNumber"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        int UpdateActivity(string ActivityNumber,string  State);
    }
}
