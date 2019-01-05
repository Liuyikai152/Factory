﻿using System;
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
        /// 查看审批活动
        /// </summary>
        /// <returns></returns>
        List<Activity> GetActivities();

        /// <summary>
        ///  修改审批流程状态
        /// </summary>
        /// <param name="ActivityNumber"></param>
        /// <param name="State"></param>
        /// <returns></returns>
        int UpdateActivity(string ActivityNumber,string  State);
    }
}
