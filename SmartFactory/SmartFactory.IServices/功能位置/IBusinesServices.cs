using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.Model;

namespace SmartFactory.IServices
{
    /// <summary>
    /// 设备业务接口
    /// </summary>
    public interface IBusinesServices
    {
        /// <summary>
        /// 显示所有设备业务
        /// </summary>
        /// <returns></returns>
        List<Business> GetBusinesses();
    }
}
