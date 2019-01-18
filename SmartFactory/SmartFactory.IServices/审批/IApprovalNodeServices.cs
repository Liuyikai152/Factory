using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.Model;

namespace SmartFactory.IServices
{

    /// <summary>
    /// 审批节点接口
    /// </summary>
    public interface IApprovalNodeServices
    {
        /// <summary>
        /// 查看审批节点
        /// </summary>
        /// <returns></returns>
        List<ApprovalNode> GetApprovalNodes();



    }
}
