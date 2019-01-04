using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{

    /// <summary>
    /// 权限表
    /// </summary>
   public class Permission
    {

        /// <summary>
        /// 权限id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 页面名称
        /// </summary>
        public string PermissionName { get; set; }

        /// <summary>
        /// 权限地址
        /// </summary>
        public string PermissionUrl { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public string IsUser { get; set; }
    }
}
