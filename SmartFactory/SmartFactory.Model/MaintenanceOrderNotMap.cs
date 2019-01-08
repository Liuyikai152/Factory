
﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
   public  class MaintenanceOrderNotMap
    {        /// <summary>
             /// 主键ID
             
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 通知单号
        
        public string OrderNumber { get; set; }

       

        /// <summary>
        /// 设备编号
        
       // public string DeviceNumber { get; set; }

        /// <summary>
        /// 设备名称
        
        public string DeviceName { get; set; }

        /// <summary>
        /// 故障名称
        
        public string FaultName { get; set; }

        /// <summary>
        /// 故障部位
        
        public string FaultPart { get; set; }

        /// <summary>
        /// 故障发生时间
        
        public DateTime HappenTime { get; set; }

        /// <summary>
        /// 处理完成时间
        
        public DateTime CompletionTime { get; set; }

        /// <summary>
        /// 停机时间
        
        public string DownTime { get; set; }

        /// <summary>
        /// 故障处理方法
        
        public string HandlingMethod { get; set; }

        /// <summary>
        /// 计划员组
        
        public string GroupName { get; set; }

        /// <summary>
        /// 维护班组名称
        
        public string ServiceName { get; set; }

        /// <summary>
        /// 成本工厂
        
        public string FactoryName3 { get; set; }

        /// <summary>
        /// 位置编码
        
        public string LocaNumber { get; set; }




        /// <summary>
        /// 位置名称
        
        public string LocaNames { get; set; }

        /// <summary>
        /// 公司名称
        
        public string CompanyName { get; set; }


        /// <summary>
        /// 计划工厂名称
        
        public string FactoryName1 { get; set; }

        /// <summary>
        /// 维护工厂
        
        public string FactoryName2 { get; set; }

        /// <summary>
        /// 地区名称
        
        public string AreaName { get; set; }

        /// <summary>
        /// 位置状态
        
        public FactoryEnum LocaState { get; set; }

        /// <summary>
        /// 包含 删除
        
        public int IsDelete { get; set; }

        /// <summary>
        /// 设备编号
        
        public string FacilityNumber { get; set; }

        /// <summary>
        /// 设备名称
        
        public string FacilityName { get; set; }

        
    }
}

