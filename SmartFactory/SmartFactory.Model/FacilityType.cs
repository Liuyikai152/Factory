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
    /// 设备种类表
    /// </summary>
    public class FacilityType
    {
        /// <summary>
        /// 主键id
        /// </summary>
        [Key]
        public int ID { get; set; }

        public string FacilityNumber { get; set; }

        /// <summary>
        /// 设备位号
        /// </summary>
        public string TypeName { get; set; }
    }
}
