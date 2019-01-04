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
    /// 测点表
    /// </summary>
    [Table("Station")]
    public class Station
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [MaxLength(50)]
        public string UnitNumber { get; set; }

        /// <summary>
        /// 测点名称
        /// </summary>
        [MaxLength(50)]
        public string StationName { get; set; }

        /// <summary>
        /// 测点编号
        /// </summary>
        [MaxLength(50)]
        public string StationNumber { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [MaxLength(50)]
        public string Measurement { get; set; }

        /// <summary>
        /// 小数位数
        /// </summary>
        public int DecimalPlace { get; set; }

        /// <summary>
        /// 采集方式
        /// </summary>
        [MaxLength(50)]
        public string ADMode { get; set; }

        /// <summary>
        /// 所属装置
        /// </summary>
        [MaxLength(50)]
        public string MyPrDeviceoperty { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [MaxLength(50)]
        public string FacilityName { get; set; }

        /// <summary>
        /// 设备位号
        /// </summary>
        [MaxLength(50)]
        public string BitNumber { get; set; }

        /// <summary>
        /// 采样频率
        /// </summary>
        public Double Frequency { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime DateChanged { get; set; }
    }
}
