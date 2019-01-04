using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
    /// <summary>
    /// 权限角色关系表
    /// </summary>
    public class PermissionRole
    {
        /// <summary>
        /// id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// 权限id
        /// </summary>
        public int PermissionId { get; set; }
    }
}
