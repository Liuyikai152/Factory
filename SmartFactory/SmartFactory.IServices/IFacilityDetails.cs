using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;
    /// <summary>
    /// 
    /// </summary>
    public interface IFacilityDetails
    {
        /// <summary>
        /// 查询设备/零件详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        FacilityDetails GetFacilityDetailsByID(string facilityNumber);
    }
}
