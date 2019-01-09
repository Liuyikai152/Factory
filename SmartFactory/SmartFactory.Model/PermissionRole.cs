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
    /// 权限角色关系表
    
    [Table("PermissionRole")]
    public class PermissionRole
    {
        /// <summary>
        /// id
        
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 角色id
        
        public int RoleId { get; set; }

        /// <summary>
        /// 权限id
        
        public int PermissionId { get; set; }
    }
}
