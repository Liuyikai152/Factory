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
    /// 设备/零件详情表
    /// <summary>
    public class FacilityDetails
    {
        /// <summary>
        /// 设备/零件ID
        /// <summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 设备编号
        /// <summary>
        public string FacilityNumber { get; set; }

        /// <summary>
        /// 设备位号
        /// <summary>
        public string BitNumber { get; set; }

        /// <summary>
        /// 设备种类
        /// <summary>
        public string FacilityKind { get; set; }

        /// <summary>
        /// ABC标识
        /// <summary>
        public string ABCSign { get; set; }

        /// <summary>
        /// 设备描述
        /// <summary>
        public DateTime Describe { get; set; }

        /// <summary>
        /// 设备分类
        /// <summary>
        public DateTime FacilityTypy { get; set; }

        /// <summary>
        /// 特殊分类
        /// <summary>
        public string SpecialType { get; set; }

        /// <summary>
        /// 开始日期
        /// <summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 修改日期
        /// <summary>
        public DateTime DateChanged { get; set; }
    }
}
