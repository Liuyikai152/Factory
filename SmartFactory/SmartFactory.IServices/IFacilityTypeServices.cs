using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;

    /// <summary>
    /// 设备种类接口
    /// </summary>
    public interface IFacilityTypeServices
    {
        /// <summary>
        /// 添加设备种类
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        int AddFacilityType(FacilityType facilitytype);

        /// <summary>
        /// 查看设备种类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<FacilityType> GetFacilityType();

        /// <summary>
        /// 删除设备种类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteFacilityType(int id);
    }
}
