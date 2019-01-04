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
    /// 主机/附机表
    /// </summary>
    [Table("Host")]
    public class Host
    {

        /// <summary>
        /// 主机/附机ID
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [MaxLength(20)]
        public string UnitNumber { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [MaxLength(20)]
        public string Type { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [MaxLength(20)]
        public string FacilityName { get; set; }

        /// <summary>
        /// 设备位号
        /// </summary>
        [MaxLength(20)]
        public string BitNumber { get; set; }

        /// <summary>
        /// 功率（KW）
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// 转速（rpm）
        /// </summary>
        public int RotateSpeed { get; set; }

        /// <summary>
        /// 流量
        /// </summary>
        public int Flow { get; set; }

        /// <summary>
        /// 出口压力
        /// </summary>
        public int Pressure { get; set; }

        /// <summary>
        /// 出口温度
        /// </summary>
        public int Temperature { get; set; }

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
