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
    /// <summary>
    [Table("ApprovalNode")]
    public class ApprovalNode
    {
        /// <summary>
        /// 审批节点主键
        /// <summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 节点名称
        /// <summary>
        public string NodeName { get; set; }

        /// <summary>
        /// 节点角色
        /// </summary>
        public string NodeRole { get; set; }
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
