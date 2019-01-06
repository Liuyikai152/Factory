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
    /// 计划员组表
    /// </summary>
    [Table("Plangroup")]
    public class Plangroup
    {
        /// <summary>
        /// 工厂区域主键
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 员组名称
        /// </summary>
        public string PlangroupName { get; set; }

        /// <summary>
        /// 员组编号
        /// </summary>
        public string PlangroupNumber { get; set; }

    }
}
