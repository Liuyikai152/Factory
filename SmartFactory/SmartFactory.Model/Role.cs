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
    /// 角色表
    /// </summary>
    [Table("Role")]
    public class Role
    {
        /// <summary>
        /// 角色id
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [MaxLength(50)]
        public string RoleName { get; set; }


        /// <summary>
        /// 角色权限
        /// </summary>
        [MaxLength(50)]
        public string Permission { get; set; }

        /// <summary>
        /// 权限id
        /// </summary>
        public string Pid { get; set; }
    }
}
