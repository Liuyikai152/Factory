using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
   public class UnitNotMapped
    {
        /// <summary>
        /// 机组ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 机组编号
        /// </summary>
        public string UnitNumber { get; set; }

        /// <summary>
        /// 机组名称
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// 机组负责人
        /// </summary>
        public string CrewLeader { get; set; }

        /// <summary>
        /// 机组图片
        /// </summary>
        public string ChartImg { get; set; }

        /// <summary>
        /// 所属装置
        /// </summary>
        public string AreaName { get; set; }

        /// <summary>
        /// 机组描述
        /// </summary>
        public string Describe { get; set; }

        /// <summary>
        /// 是否报警
        /// </summary>
        public FactoryEnum IsSiren { get; set; }

        /// <summary>
        /// 主机名
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// 附机名
        /// </summary>
        public string AttachName { get; set; }
    }
}
