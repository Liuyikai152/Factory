using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Model
{
   public  class PumpNotMap
    {
        /// <summary>
        /// 机泵ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 机泵编号
        /// </summary>
        public string PumpNumber { get; set; }

        /// <summary>
        /// 机泵名称
        /// </summary>
        public string PumpName { get; set; }

        /// <summary>
        /// 机泵负责人
        /// </summary>
        public string Principal { get; set; }

        /// <summary>
        /// 机泵图片
        /// </summary>
        public string StructureImg { get; set; }

        /// <summary>
        /// 所属装置
        /// </summary>
        public string AreaName { get; set; }

        /// <summary>
        /// 机泵描述
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
