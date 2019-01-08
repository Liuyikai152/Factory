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
    /// 设备制造商数据表
    
    public class FacilityManuFacturer
    {
        /// <summary>
        /// 设备/零件ID
        
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 设备编号
        
        public string FacilityNumber { get; set; }

        /// <summary>
        /// 制造商
        
        public string ManuFacturer { get; set; }

        /// <summary>
        /// 制造商国家
        
        public string ManuCountry { get; set; }

        /// <summary>
        /// 序列号
        
        public string SerialNumber { get; set; }

        /// <summary>
        /// 制造年月
        
        public DateTime MakeMonthly { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>

        public DateTime DateChanged { get; set; }
    }
}
