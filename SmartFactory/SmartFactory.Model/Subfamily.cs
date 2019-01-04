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
    /// 子系列类表
    /// </summary>
    [Table("Subfamily")]
    public class Subfamily
    {

        /// <summary>
        /// 子系列ID
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        public string UnitNumber { get; set; }

        /// <summary>
        /// 子系统名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 功能描述
        /// </summary>
        public string Describe { get; set; }

        /// <summary>
        /// 结构图片
        /// </summary>
        public string ChartImg  { get; set; }

        /// <summary>
        /// 系统编号
        /// </summary>
        public string SubfamilyNumber { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime DateChanged { get; set; }

        /// <summary>
        /// 机组Or机泵
        /// </summary>
        public int UnitOrPump { get; set; }

    }
}
