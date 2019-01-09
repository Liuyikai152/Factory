 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
   public class FacilityNotMapp
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
        /// 设备位置
        
        public string BitNumbers { get; set; }

        /// <summary>
        /// 公司名称
        
        public string CompanyName { get; set; }

        /// <summary>
        /// 计划工厂
        
        public string FactoryName { get; set; }

        /// <summary>
        /// 维护工厂
        
        public string FactoryName1 { get; set; }

        /// <summary>
        /// 工作区域
        
        public string AreaName { get; set; }

        /// <summary>
        /// 计划员组
        
        public string GroupName { get; set; }
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
        /// 是否报警
        
        public int IsSiren { get; set; }

        /// <summary>
        /// 设备安装位置
        
        public string FacilityLoca { get; set; }

        /// <summary>
        /// 设备种类
        
        public string TypeName { get; set; }
    }
}
