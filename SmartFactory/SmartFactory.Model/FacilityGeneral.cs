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
    
    public class FacilityGeneral
    {
        /// <summary>
        /// 设备/零件ID
        
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 设备编号
        
        public string FacilityNumber { get; set; }

        /// <summary>
        /// 重量
        
        public string Weight { get; set; }

        /// <summary>
        /// 大小尺寸
        
        public string Size { get; set; }

        /// <summary>
        /// 购置值
        
        public string PurchaseValue { get; set; }

        /// <summary>
        /// 库存号
        
        public string StockNumber { get; set; }

        /// <summary>
        /// 购置日期
        
        public DateTime PurchaseDate { get; set; }

        /// <summary>
        /// 安装日期
        
        public DateTime InstallationDate { get; set; }

        /// <summary>
        /// 投用日期
        
        public DateTime PutIntoDate { get; set; }

    }
}
