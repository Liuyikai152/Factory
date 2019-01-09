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
    /// 审批节点表
    
    [Table("ApprovalNode")]
    public class ApprovalNode
    {
        /// <summary>
        /// 审批节点主键
        
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 节点名称
        
        public int NodeName { get; set; }

        /// <summary>
        /// 创建人
        
        public string Creator { get; set; }

        /// <summary>
        /// 创建时间
        
        public DateTime CreateTime { get; set; }
    }
}
