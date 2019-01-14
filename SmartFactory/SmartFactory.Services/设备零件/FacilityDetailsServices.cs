using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Services
{
    using SmartFactory.Model;
    using SmartFactory.IServices;

    /// <summary>
    /// 设备/零件详情实现类
    /// </summary>
    public class FacilityDetailsServices:IFacilityDetailsServices
    {

        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 查询设备/零件详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FacilityDetails GetFacilityDetailsByID(string  facilityNumber)
        {
            try
            {
                return factoryDBcontext.FacilityDetails.FirstOrDefault(n => n.FacilityNumber.Contains(facilityNumber));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
