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
    /// 审批流程表
    /// </summary>
    [Table("Process")]
    public class Process
    {
        /// <summary>
        /// 审批流程主键
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 流程名称
        /// </summary>
        [MaxLength(20)]
        public string Name { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [MaxLength(20)]
        public string Creator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
