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
    /// 位置类型表
    
    [Table("LocaType")]
    public class LocaType
    {

        /// <summary>
        /// 主键id
        
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 位置名称
        
        public string LocalName { get; set; }

        /// <summary>
        /// 位置名称
        
        public string LocalNumber { get; set; }
    }
}
