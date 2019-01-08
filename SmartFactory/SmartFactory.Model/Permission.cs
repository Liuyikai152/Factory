﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    /// <summary>
    /// 权限表
    
    [Table("Permission")]
    public class Permission
    {

        /// <summary>
        /// 权限id
        
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 页面名称
        
        public string PermissionName { get; set; }

        /// <summary>
        /// 权限地址
        
        public string PermissionUrl { get; set; }

        /// <summary>
        /// 是否启用
        
        public int IsUser { get; set; }
    }
}
