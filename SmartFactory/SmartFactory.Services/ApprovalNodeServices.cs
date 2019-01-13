using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{

    /// <summary>
    /// 审批节点实现类
    /// </summary>
    public class ApprovalNodeServices : IApprovalNodeServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 查看审批节点
        /// </summary>
        /// <returns></returns>
        public List<ApprovalNode> GetApprovalNodes()
        {
            var approvalNodeList = from a in factoryDBcontext.ApprovalNode.ToList() select a;
            return approvalNodeList.ToList();
        }
    }
}
