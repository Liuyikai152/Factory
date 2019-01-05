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
    /// </summary>
    [Table("CompanyCode")]
    public class CompanyCode
    {
        /// <summary>
        /// 公司主键
        /// </summary>
        [Key]
        public int ID { get; set; }
  
        /// <summary>
        /// 公司名称
        /// </summary>
        
        public string CompanyName { get; set; }
        
        /// <summary>
        /// 公司编号
        /// </summary>
    
        public string CompanyCodes { get; set; }
    }
}
