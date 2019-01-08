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
    /// 公司编号表
    
    [Table("CompanyCode")]
    public class CompanyCode
    {
        /// <summary>
        /// 公司主键
        
        [Key]
        public int ID { get; set; }
  
        /// <summary>
        /// 公司名称
                
        public string CompanyName { get; set; }
        
        /// <summary>
        /// 公司编号
            
        public string CompanyCodes { get; set; }
    }
}
