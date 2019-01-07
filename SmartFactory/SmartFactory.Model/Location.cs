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
    /// 功能位置表
    /// </summary>
    [Table("LocaTion")]
    public class LocaTion
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 位置编码
        /// </summary>
        public string LocaNumber { get; set; }

        /// <summary>
        /// 位置关联
        /// </summary>
        public string LocaNamess { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [NotMapped]
        public string LocalName { get; set; }

        /// <summary>
        /// 公司编号
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [NotMapped]
        public string CompanyName { get; set; }

        /// <summary>
        /// 计划工厂
        /// </summary>
        public string PlanFactory { get; set; }

        /// <summary>
        /// 计划工厂名称
        /// </summary>
        [NotMapped]
        public string FactoryName1 { get; set; }
       
        /// <summary>
        /// 维护工厂
        /// </summary>
        public string MaintainFactory  { get; set; }
        
        /// <summary>
        /// 维护工厂名称
        /// </summary>
        [NotMapped]
        public string FactoryName2 { get; set; }
        /// <summary>
        /// 工作区域
        /// </summary>
        public string FactoryArea { get; set; }

        [NotMapped]
        public string AreaName { get; set; }
        /// <summary>
        /// 计划员组
        /// </summary>
        public string PlanGroup { get; set; }

        /// <summary>
        /// 计划员组名称
        /// </summary>
        [NotMapped]
        public string GroupName { get; set; }


        /// <summary>
        /// 维护班组编号
        /// </summary>
        public string ServiceNumber { get; set; }

        /// <summary>
        /// 维护班组名称
        /// </summary>
        [NotMapped]
        public string ServiceName { get; set; }

        /// <summary>
        /// 成本中心
        /// </summary>
        public string CostConter { get; set; }

        /// <summary>
        /// 成本工厂
        /// </summary>
        [NotMapped]
        public string FactoryName3 { get; set; }

        /// <summary>
        /// 位置类型
        /// </summary>
        public string LocaType { get; set; }

        /// <summary>
        /// 位置状态
        /// </summary>
        public  FactoryEnum LocaState { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime DateChanged { get; set; }

        /// <summary>
        /// 业务范围
        /// </summary>
        public string BusinessLine { get; set; }

        /// <summary>
        /// 是否安装
        /// </summary>
        public int IsInstall { get; set; }

        /// <summary>
        /// 包含 删除
        /// </summary>
        public int IsDelete { get; set; }

    }
}
