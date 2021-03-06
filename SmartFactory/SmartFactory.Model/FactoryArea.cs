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
    /// 工厂区域表
    /// <summary>
    [Table("FactoryArea")]
    public class FactoryArea
    {
        /// <summary>
        /// 工厂区域主键
        /// <summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 区域名称
        /// <summary>
        public string AreaName { get; set; }

        /// <summary>
        /// 区域编号
        /// <summary>
        public string AreaNumber { get; set; }
    }
}
