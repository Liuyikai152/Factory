using SmartFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
   /// <summary>
   /// 工厂接口
   /// </summary>
  public   interface IPlanfactoryServices
    {
        /// <summary>
        /// 查看所有工厂
        /// </summary>
        /// <returns></returns>
        List<Planfactory> GetPlanfactories();
    }
}
