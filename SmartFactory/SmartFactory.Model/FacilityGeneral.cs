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
    /// 设备一般数据表
    /// </summary>
    public class FacilityGeneral
    {
        /// <summary>
        /// 设备/零件ID
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        public string FacilityNumber { get; set; }

        /// <summary>
        /// 重量
        /// </summary>
        public string Weight { get; set; }

        /// <summary>
        /// 大小尺寸
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// 购置值
        /// </summary>
        public string PurchaseValue { get; set; }

        /// <summary>
        /// 库存号
        /// </summary>
        public string StockNumber { get; set; }

        /// <summary>
        /// 购置日期
        /// </summary>
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// 安装日期
        /// </summary>
        public DateTime InstallationDate { get; set; }

        /// <summary>
        /// 投用日期
        /// </summary>
        public DateTime PutIntoDate { get; set; }

    }
}
