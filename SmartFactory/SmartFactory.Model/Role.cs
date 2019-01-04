using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
    /// <summary>
    /// 角色表
    /// </summary>
   public class Role
    {
        /// <summary>
        /// 角色id
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }


        /// <summary>
        /// 角色权限
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// 权限id
        /// </summary>
        public string Pid { get; set; }
    }
}
