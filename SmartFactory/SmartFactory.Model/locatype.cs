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
    /// 位置类型表
    /// </summary>
    [Table("LocaType")]
    public class Locatype
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [MaxLength(20)]
        public string LocalName { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [MaxLength(20)]
        public string LocalNumber { get; set; }
    }
}
