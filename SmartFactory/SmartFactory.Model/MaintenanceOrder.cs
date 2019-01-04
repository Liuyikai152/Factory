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
    /// 维修工单表
    /// </summary>
    [Table("MaintenanceOrder")]
    public class MaintenanceOrder
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 通知单号
        /// </summary>
        [MaxLength(20)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// 所属机组/机泵
        /// </summary>
        [MaxLength(20)]
        public string Belongs { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        [MaxLength(20)]
        public string DeviceNumber { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [MaxLength(20)]
        public string DeviceName { get; set; }

        /// <summary>
        /// 故障名称
        /// </summary>
        [MaxLength(20)]
        public string FaultName { get; set; }

        /// <summary>
        /// 故障部位
        /// </summary>
        [MaxLength(20)]
        public string FaultPart { get; set; }

        /// <summary>
        /// 故障发生时间
        /// </summary>
        public DateTime HappenTime { get; set; }

        /// <summary>
        /// 处理完成时间
        /// </summary>
        public DateTime CompletionTime { get; set; }

        /// <summary>
        /// 停机时间
        /// </summary>
        [MaxLength(20)]
        public string DownTime { get; set; }

        /// <summary>
        /// 故障处理方法
        /// </summary>
        [MaxLength(20)]
        public string HandlingMethod { get; set; }
    }
}
