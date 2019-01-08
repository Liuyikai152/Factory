using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;

    /// <summary>
    /// 设备/零件数据接口
    /// </summary>
    public interface IFacilityServices
    {
        /// <summary>
        /// 查看设备/零件数据
        /// </summary>
        /// <returns></returns>

        List<FacilityNotMapp> GetFacility();


        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        FacilityNotMapp GetById(int id);
    }
}
