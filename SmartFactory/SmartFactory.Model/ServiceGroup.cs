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
    /// 维护班组
    /// </summary>
    [Table("ServiceGroup")]
    public class ServiceGroup
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 班组名称
        /// </summary>
        [MaxLength(50)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 班组编号
        /// </summary>
        [MaxLength(50)]
        public string ServiceNumber { get; set; }
    }
}
