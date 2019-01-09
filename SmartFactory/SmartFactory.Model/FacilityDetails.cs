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
    
    public class FacilityDetails
    {
        /// <summary>
        /// 设备/零件ID
        
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 设备编号
        
        public string FacilityNumber { get; set; }

        /// <summary>
        /// 设备位号
        
        public string BitNumber { get; set; }

        /// <summary>
        /// 设备种类
        
        public string FacilityKind { get; set; }

        /// <summary>
        /// ABC标识
        
        public string ABCSign { get; set; }

        /// <summary>
        /// 设备描述
        
        public DateTime Describe { get; set; }

        /// <summary>
        /// 设备分类
        
        public DateTime FacilityTypy { get; set; }

        /// <summary>
        /// 特殊分类
        
        public string SpecialType { get; set; }

        /// <summary>
        /// 开始日期
        
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 修改日期
        
        public DateTime DateChanged { get; set; }
    }
}
