using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.Model;

namespace SmartFactory.IServices
{
    /// <summary>
    /// 位置类型接口
    /// </summary>
    public interface ILocaTypeServices
    {
        /// <summary>
        /// 查看所有位置类型
        /// </summary>
        /// <returns></returns>
        List<LocaType> GetLocaTypes();
    }
}
