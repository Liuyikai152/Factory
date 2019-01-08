using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    [Table("Facility")]
   public class Facility
    {
        /// <summary>
        /// 主键ID
        
        public int ID { get; set; }

        /// <summary>
        /// 设备编号
        
        public string FacilityNumber { get; set; }

        /// <summary>
        /// 设备名称
        
        public string FacilityName { get; set; }

        /// <summary>
        /// 设备位号
        
        public string BitNumber { get; set; }

        /// <summary>
        /// 公司编号
        
        public string CompanyCode { get; set; }

        /// <summary>
        /// 计划工厂
        
        public string PlanFactory { get; set; }

        /// <summary>
        /// 维护工厂
        
        public string MaintainFactory { get; set; }

        /// <summary>
        /// 工厂区域
        
        public string FactoryArea { get; set; }

        /// <summary>
        /// 计划员组
        
        public string PlanGroup { get; set; }

        /// <summary>
        /// 成本中心
        
        public string CostConter { get; set; }

        /// <summary>
        /// 位置类型
        
        //public string LocaType { get; set; }

        /// <summary>
        /// 位置状态
        
        //public FactoryEnum LocaState { get; set; }

        /// <summary>
        /// 开始日期
        
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 修改日期
        
        public DateTime DateChanged { get; set; }

        /// <summary>
        /// 业务范围
        
        public string BusinessLine { get; set; }

        /// <summary>
        /// 是否安装位置
        
        public int IsInstall { get; set; }

        /// <summary>
        /// 包含删除
        
        public int IsDelete { get; set; }

        /// <summary>
        /// 维护班组编号
        

        public string ServiceNumber { get; set; }

        /// <summary>
        /// 是否报警
        
        public int IsSiren { get; set; }

        /// <summary>
        /// 设备种类
        
        public string FacilityType { get; set; }

        /// <summary>
        /// 设备安装位置
        
        public string FacilityLoca { get; set; }
    }
}
