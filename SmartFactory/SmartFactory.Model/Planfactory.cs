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
    /// 工厂表
    /// </summary>
    [Table("Planfactory")]
    public class Planfactory
    {
        /// <summary>
        /// 工厂主键
        /// </summary>
        [Key]
        public int ID { get; set; }
      
        /// <summary>
        /// 工厂名称
        /// </summary>
        [MaxLength(20)]
        public string FactoryName { get; set; }
      
        /// <summary>
        /// 工厂编号
        /// </summary>
        [MaxLength(20)]
        public string FactoryNumber { get; set; }
    
        /// <summary>
        /// 关联ID
        /// </summary>
        public int Pid { get; set; }
    }
}
