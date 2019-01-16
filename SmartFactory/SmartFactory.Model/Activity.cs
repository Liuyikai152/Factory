using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// 审批活动表
    
    [Table("Activity")]
    public class Activity
    {
        /// <summary>
        /// 审批配置主键
        
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 审批流程ID
        
        public int? ProcessID { get; set; }

        /// <summary>
        /// 审批节点ID
        
        public int? NodeID { get; set; }

        /// <summary>
        /// 配置流程编码
        
        public string ProcessCode { get; set; }

        /// <summary>
        /// 下一步审批角色ID
        
        public int? ApprovalRoleID { get; set; }

        /// <summary>
        /// 审批流程ID
        
        public int? NextApprovalRoleID { get; set; }

        /// <summary>
        /// 下一步审批角色ID
        
        public int? ApprovalUserID { get; set; }

        /// <summary>
        /// 审批流程ID
        
        public int? NextApprovalUserID { get; set; }

        /// <summary>
        /// 判断条件ID
        
        public int? JudgmentID { get; set; }

        /// <summary>
        /// 审批状态ID
        
        public int? StateID { get; set; }

        /// <summary>
        /// 实际审批状态
        
        public int? TureStateID { get; set; }

        /// <summary>
        /// 创建人
        

        public string Creator { get; set; }

        /// <summary>
        /// 创建时间
        
        public DateTime? CreateTime { get; set; }
    }
}
