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
    /// <summary>
    [Table("PermissionRole")]
    public class PermissionRole
    {
        /// <summary>
        /// id
        /// <summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 角色id
        /// <summary>
        public int RoleId { get; set; }

        /// <summary>
        /// 权限id
        /// <summary>
        public int PermissionId { get; set; }
    }
}
