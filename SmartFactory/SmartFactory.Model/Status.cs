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
    /// 审批状态表
    /// </summary>
    [Table("Status")]
    public class Status
    {
        /// <summary>
        /// 审批状态主键
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 审批状态
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
