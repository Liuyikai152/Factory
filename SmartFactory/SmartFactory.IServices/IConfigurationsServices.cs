using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;
    public interface IConfigurationsServices
    {
        /// <summary>
        /// 添加审批流程配置
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        int AddConfiguration(Configuration configuration);

        /// <summary>
        /// 查看审批活动
        /// </summary>
        /// <returns></returns>
        List<Configuration> GetActivities();

        /// <summary>
        /// 删除审批活动
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteConfiguration(int id);
    }
}
