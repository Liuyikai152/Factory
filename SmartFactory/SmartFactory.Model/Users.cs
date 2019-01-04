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
    /// 用户表
    /// </summary>
    [Table("Users")]
    public class Users
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        [MaxLength(50)]
        public string PassWord { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [MaxLength(50)]
        public string RoleId { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        [MaxLength(50)]
        public string RoleName { get; set; }

        /// <summary>
        /// 权限路径
        /// </summary>
        [MaxLength(100)]
        public string PermissionUrl { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
