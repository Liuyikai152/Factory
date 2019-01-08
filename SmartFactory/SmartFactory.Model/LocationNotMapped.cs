using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
   public  class LocationNotMapped
    {

        /// <summary>
        /// 主键ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 计划员组名称
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 位置编码
        /// </summary>
        public string LocaNumber { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        public string LocalName { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 是否安装
        /// </summary>
        public int IsInstall { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 计划工厂名称
        /// </summary>
        public string FactoryName1 { get; set; }

        /// <summary>
        /// 维护工厂
        /// </summary>
        public string FactoryName2 { get; set; }

        /// <summary>
        /// 地区名称
        /// </summary>
        public string AreaName { get; set; }

        /// <summary>
        /// 维护班组名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 工厂区域
        /// </summary>
        public string FactoryArea { get; set; }
        /// <summary>
        /// 成本工厂
        /// </summary>
        public string FactoryName3 { get; set; }

        /// <summary>
        /// 位置状态
        /// </summary>
        public FactoryEnum LocaState { get; set; }

        /// <summary>
        /// 包含 删除
        /// </summary>
        public int IsDelete { get; set; }

    }
}
