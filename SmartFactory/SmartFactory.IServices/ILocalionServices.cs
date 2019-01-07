using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.Model;

namespace SmartFactory.IServices
{
    /// <summary>
    /// 功能位置接口
    /// </summary>
    public interface ILocalionServices
    {
        /// <summary>
        /// 查看功能位置
        /// </summary>
        /// <returns></returns>
        List<LocationNotMapped> GetLocations();


        /// <summary>
        /// 查看单个位置详情
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        LocationNotMapped GetLocationById(int id);



    }
}
