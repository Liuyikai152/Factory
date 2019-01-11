using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
    public class ConfigurationNotMapped
    {
        public int ID { get; set; }
        public string Condition { get; set; }
        public string State { get; set; }
        public string TureState { get; set; }
        public string NodeName { get; set; }
        public string UserName { get; set; }
        public string NextUserName { get; set; }


        /// <summary>
        /// 审批流程ID
        /// <summary>
        public int ProcessID { get; set; }

        /// <summary>
        /// 审批节点ID
        /// <summary>
        public int NodeID { get; set; }

        /// <summary>
        /// 配置流程编码
        /// <summary>
        public string ProcessCode { get; set; }

        /// <summary>
        /// 审批角色ID
        /// <summary>
        public int ApprovalRoleID { get; set; }

        /// <summary>
        /// 下一步审批角色ID
        /// <summary>
        public int NextApprovalRoleID { get; set; }

        /// <summary>
        /// 审批人员ID
        /// <summary>
        public int ApprovalUserID { get; set; }

        /// <summary>
        /// 下一步审批人员ID
        /// <summary>
        public int NextApprovalUserID { get; set; }

        /// <summary>
        /// 判断条件ID
        /// <summary>
        public int JudgmentID { get; set; }

        /// <summary>
        /// 审批状态ID
        /// <summary>
        public int StateID { get; set; }

        /// <summary>
        /// 实际审批状态ID
        /// <summary>
        public int TureStateID { get; set; }

        /// <summary>
        /// 创建人
        /// <summary>
        public string Creator { get; set; }

        /// <summary>
        /// 创建时间
        /// <summary>
        public DateTime CreateTime { get; set; }
    }
}
