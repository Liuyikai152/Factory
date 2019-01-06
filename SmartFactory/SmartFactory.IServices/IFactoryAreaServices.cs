using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SmartFactory.Model;

namespace SmartFactory.IServices
{
    /// <summary>
    /// 工厂区域接口
    /// </summary>
  public interface IFactoryAreaServices
    {
        /// <summary>
        /// 显示工厂区域
        /// </summary>
        /// <returns></returns>
        List<FactoryArea> GetFactoryAreas();
    }
}
