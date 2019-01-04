using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SmartFactory.Model
{
    /// <summary>
    /// 机泵表
    /// </summary>
    [Table("Pump")]
    public  class Pump
    {
        /// <summary>
        /// 机泵ID
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 机泵编号
        /// </summary>
        [MaxLength(50)]
        public string PumpNumber { get; set; }

        /// <summary>
        /// 机泵名称
        /// </summary>
        [MaxLength(50)]
        public string PumpName { get; set; }

        /// <summary>
        /// 机泵负责人
        /// </summary>
        [MaxLength(50)]
        public string Principal { get; set; }

        /// <summary>
        /// 机泵图片
        /// </summary>
        [MaxLength(50)]
        public string StructureImg { get; set; }

        /// <summary>
        /// 机泵描述
        /// </summary>
        [MaxLength(50)]
        public string Describe { get; set; }

        /// <summary>
        /// 所属装置
        /// </summary>
        [MaxLength(50)]
        public string Device { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime DateChanged { get; set; }

        /// <summary>
        /// 是否报警
        /// </summary>
        public FactoryEnum IsSiren { get; set; }
    }
}
