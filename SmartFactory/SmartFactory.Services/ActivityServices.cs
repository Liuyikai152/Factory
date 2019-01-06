using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.IServices;
using SmartFactory.Model;
using System.Data.Entity;

namespace SmartFactory.Services
{

    /// <summary>
    /// 审批活动实现类
    /// </summary>
    public class ActivityServices : IActivityServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加审批活动
        /// </summary>
        /// <param name="activity"></param>
        /// <returns></returns>
        public int AddActivity(Activity activity)
        {
            factoryDBcontext.Activities.Add(activity);

            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 查看审批活动
        /// </summary>
        /// <returns></returns>
        public List<Activity> GetActivities()
        {
            var activityList = factoryDBcontext.Database.SqlQuery<Activity>("").ToList();
            return activityList;
        }

        /// <summary>
        ///  修改审批流程状态
        /// </summary>
        /// <param name="ActivityNumber"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public int UpdateActivity(string ActivityNumber, string State)
        {

           var i= factoryDBcontext.Database.ExecuteSqlCommand("");

            return factoryDBcontext.SaveChanges(); 
        }
    }
}
