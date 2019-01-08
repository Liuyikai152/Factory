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
    /// 设备位号表
    
    [Table("BitNumber")]
    public class BitNumber
    {
        /// <summary>
        /// 主键id
        
        [Key]
        public int ID { get; set; }

        public string FacilityNumber { get; set; }

        /// <summary>
        /// 设备位号
        
        public string BitNumbers { get; set; }
    }
}
