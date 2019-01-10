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
    /// 设备业务表
    
    [Table("Business")]
    public  class Business
    {
        /// <summary>
        /// 主键id
        /// <summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 业务名称
        /// <summary>

        public string BusionessName { get; set; }

        /// <summary>
        /// 业务编号
        /// <summary>
        public string BusionessNumber { get; set; }
    }
}
