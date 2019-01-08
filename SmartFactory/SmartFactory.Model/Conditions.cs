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
    /// 审批条件表
    
    [Table("Conditions")]
    public class Conditions
    {
        /// <summary>
        /// 审批条件主键
        
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 审批条件
        
        public string Condition { get; set; }
       
        /// <summary>
        /// 创建时间
        
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// 编辑时间
        
        public DateTime Edittime { get; set; }
    }
}
