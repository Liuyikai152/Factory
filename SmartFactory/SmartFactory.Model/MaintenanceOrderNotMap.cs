using System;
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
             /// </summary>
        [Key]
        public int ID { get; set; }

        /// <summary>
        /// 通知单号
        /// </summary>
        public string OrderNumber { get; set; }

       

        /// <summary>
        /// 设备编号
        /// </summary>
       // public string DeviceNumber { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        public string DeviceName { get; set; }

        /// <summary>
        /// 故障名称
        /// </summary>
        public string FaultName { get; set; }

        /// <summary>
        /// 故障部位
        /// </summary>
        public string FaultPart { get; set; }

        /// <summary>
        /// 故障发生时间
        /// </summary>
        public DateTime HappenTime { get; set; }

        /// <summary>
        /// 处理完成时间
        /// </summary>
        public DateTime CompletionTime { get; set; }

        /// <summary>
        /// 停机时间
        /// </summary>
        public string DownTime { get; set; }

        /// <summary>
        /// 故障处理方法
        /// </summary>
        public string HandlingMethod { get; set; }

        /// <summary>
        /// 计划员组
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 维护班组名称
        /// </summary>
        public string ServiceName { get; set; }

        /// <summary>
        /// 成本工厂
        /// </summary>
        public string FactoryName3 { get; set; }

        /// <summary>
        /// 位置编码
        /// </summary>
        public string LocaNumber { get; set; }




        /// <summary>
        /// 位置名称
        /// </summary>
        public string LocaNames { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }


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
        /// 位置状态
        /// </summary>
        public FactoryEnum LocaState { get; set; }

        /// <summary>
        /// 包含 删除
        /// </summary>
        public int IsDelete { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        public string FacilityNumber { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        public string FacilityName { get; set; }

        
    }
}
