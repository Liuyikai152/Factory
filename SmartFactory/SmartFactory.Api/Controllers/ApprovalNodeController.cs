using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartFactory.Api.Controllers
{
    using SmartFactory.IServices;
    using SmartFactory.Model;
    using SmartFactory.Services;

    [RoutePrefix("ApprovalNode")]
    public class ApprovalNodeController : ApiController
    {
        public IApprovalNodeServices approvalNodeServices { get; set; }

        /// <summary>
        /// 查看审批节点
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetApprovalNodes")]
        public List<ApprovalNode> GetApprovalNodes()
        {
            var approvalNodeList = approvalNodeServices.GetApprovalNodes();
            return approvalNodeList;
        }
    }
}
