using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.Model;

namespace SmartFactory.IServices
{

    /// <summary>
    /// 维护班组接口
    /// </summary>
    public interface IServiceGroupServices
    {
        /// <summary>
        /// 查看所有维护班组
        /// </summary>
        /// <returns></returns>
        List<ServiceGroup> GetServiceGroups();
    }
}
