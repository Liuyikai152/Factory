using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;

    /// <summary>
    /// 制造商接口
    /// </summary>
    public interface IFacilityManuFacturer
    {
        /// <summary>
        /// 添加制造商
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        int AddFacilityManu(FacilityManuFacturer facilitymanu);

        /// <summary>
        /// 根据ID查制造商
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        FacilityManuFacturer GetFacilityManuByID(string facilityNumber);

        /// <summary>
        /// 删除制造商
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteFacilityManu(int id);
    }
}
