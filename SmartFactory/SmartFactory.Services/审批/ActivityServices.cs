using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.IServices;
using SmartFactory.Model;
using System.Data.Entity;
using MySql.Data.MySqlClient;

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
        public int AddActivity(int judgment)
        {
            var configurationList = (from a in factoryDBcontext.Configurations.ToList() where a.JudgmentID == judgment select a).ToList();

            Activity activity = new Activity();
            for (int i = 0; i < configurationList.Count(); i++)
            {
                activity.ProcessCode = configurationList[i].ProcessCode;
                activity.JudgmentID = Convert.ToInt32(configurationList[i].JudgmentID);
                activity.NodeID = Convert.ToInt32(configurationList[i].NodeID);
                activity.ApprovalUserID = Convert.ToInt32(configurationList[i].ApprovalUserID);
                activity.NextApprovalUserID = Convert.ToInt32(configurationList[i].NextApprovalUserID);
                activity.StateID = Convert.ToInt32(configurationList[i].StateID);
                activity.TureStateID = Convert.ToInt32(configurationList[i].TureStateID);

                factoryDBcontext.Activities.Add(activity);
                factoryDBcontext.SaveChanges();
            }

            return 1;
        }

        /// <summary>
        /// 查看审批活动
        /// </summary>
        /// <returns></returns>
        public List<ActivityNotMappit> GetActivities(string name, string state)
        {
            MySqlParameter[] mySqlParameter = new MySqlParameter[]
            {
                new MySqlParameter ("@userNames",name),
                new MySqlParameter ("@states",state),
            };
            var activityList = factoryDBcontext.Database.SqlQuery<ActivityNotMappit>("CALL Pro_GetActivity (@userNames, @states)", mySqlParameter).ToList();
            return activityList;
        }

        /// <summary>
        /// 修改审批状态
        /// </summary>
        /// <param name="facility"></param>
        /// <returns></returns>
        public int UpdateState(int ID, int trueState, int state)
        {
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@ids",ID),
                new MySqlParameter("@trueState",trueState),
            };
            factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_UpdateTrueState(@ids,@trueState)", parameters);
          
            var i = factoryDBcontext.Activities.FirstOrDefault(n => n.ID.Equals(ID + 1));
            if (i != null)
            {
                if (i.NextApprovalUserID != null)
                {
                    MySqlParameter[] mySqlParameters = new MySqlParameter[]
                    {
                            new MySqlParameter("@ids",i.ID),
                            new MySqlParameter("@state",state),
                    };
                    factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_UpdateState(@ids,@state)", mySqlParameters);
                }
            }
            return 1;
        }


        /// <summary>
        /// 驳回审批状态
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="trueState"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public int UpdateNoState(int ID, int trueState)
        {
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@ids",ID),
                new MySqlParameter("@trueState",trueState),
            };
            return factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_UpdateTrueState(@ids,@trueState)", parameters);             
        }

        /// <summary>
        ///  修改审批流程状态
        /// </summary>
        /// <param name="ActivityNumber"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        public int UpdateActivity(string ActivityNumber, string State)
        {
            var i = factoryDBcontext.Database.ExecuteSqlCommand("");
            return factoryDBcontext.SaveChanges();
        }
    }
}
