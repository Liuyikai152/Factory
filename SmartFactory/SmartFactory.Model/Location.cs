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
        [MaxLength(20)]
        public string LocaNumber { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [MaxLength(20)]
        public string LocaName { get; set; }

        /// <summary>
        /// 公司编号
        /// </summary>
        [MaxLength(20)]
        public string CompanyCode { get; set; }

        /// <summary>
        /// 计划工厂
        /// </summary>
        [MaxLength(20)]
        public string PlanFactory { get; set; }

        /// <summary>
        /// 维护工厂
        /// </summary>
        [MaxLength(20)]
        public string MaintainFactory { get; set; }

        /// <summary>
        /// 工作区域
        /// </summary>
        [MaxLength(20)]
        public string FactoryArea { get; set; }

        /// <summary>
        /// 计划员组
        /// </summary>
        [MaxLength(20)]
        public string PlanGroup { get; set; }

        /// <summary>
        /// 成本中心
        /// </summary>
        [MaxLength(20)]
        public string CostConter { get; set; }

        /// <summary>
        /// 位置类型
        /// </summary>
        [MaxLength(20)]
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
        [MaxLength(20)]
        public string BusinessLine { get; set; }

        /// <summary>
        /// 是否安装
        /// </summary>
        public int IsInstall { get; set; }

        /// <summary>
        /// 包含 删除
        /// </summary>
        public int IsDelete { get; set; }

        /// <summary>
        /// 维护班组编号
        /// </summary>
        [MaxLength(20)]
        public string ServiceNumber { get; set; }
    }
}
