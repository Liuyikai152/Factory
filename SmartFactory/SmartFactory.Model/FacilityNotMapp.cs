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
        /// <summary>
        public int ID { get; set; }

        /// <summary>
        /// 设备编号
        /// <summary>
        public string FacilityNumber { get; set; }

        /// <summary>
        /// 设备名称
        /// <summary>
        public string FacilityName { get; set; }

        /// <summary>
        /// 设备位置
        /// <summary>
        public string BitNumbers { get; set; }

        /// <summary>
        /// 公司名称
        /// <summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 计划工厂
        /// <summary>
        public string FactoryName { get; set; }

        /// <summary>
        /// 维护工厂
        /// <summary>
        public string FactoryName1 { get; set; }

        /// <summary>
        /// 工作区域
        /// <summary>
        public string AreaName { get; set; }

        /// <summary>
        /// 计划员组
        /// <summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 位置状态
        /// <summary>
        //public FactoryEnum LocaState { get; set; }

        /// <summary>
        /// 开始日期
        /// <summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 修改日期
        /// <summary>
        public DateTime DateChanged { get; set; }

        /// <summary>
        /// 业务范围
        /// <summary>
        public string BusinessLine { get; set; }

        /// <summary>
        /// 是否安装位置
        /// <summary>
        public int IsInstall { get; set; }

        /// <summary>
        /// 包含删除
        /// <summary>
        public FactoryEnum IsDelete { get; set; }

        /// <summary>
        /// 是否报警
        /// <summary>
        public FactoryEnum IsSiren { get; set; }

        /// <summary>
        /// 设备安装位置
        /// <summary>
        public string FacilityLoca { get; set; }

        /// <summary>
        /// 设备种类
        /// <summary>
        public string TypeName { get; set; }
    }
}
