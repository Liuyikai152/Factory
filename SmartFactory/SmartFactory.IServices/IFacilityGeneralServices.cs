using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.IServices
{
    using SmartFactory.Model;
   public interface IFacilityGeneralServices
    {
        /// <summary>
        /// 添加制造商
        /// </summary>
        /// <param name="facilitygeneral"></param>
        /// <returns></returns>
        int AddFacilityGeneral(FacilityGeneral facilitygeneral);

        /// <summary>
        /// 根据ID查制造商
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        FacilityGeneral GetFacilityGeneralByID(string facilityNumber);

        /// <summary>
        /// 删除制造商
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteFacilityGeneral(int id);
    }
}
