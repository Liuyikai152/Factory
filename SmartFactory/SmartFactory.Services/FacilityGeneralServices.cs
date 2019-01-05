using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.Services
{
    using SmartFactory.Model;
    using SmartFactory.IServices;

    /// <summary>
    /// 设备一般数据实现类
    /// </summary>
    public class FacilityGeneralServices:IFacilityGeneral
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加一般数据
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        public int AddFacilityGeneral(FacilityGeneral facilitygeneral)
        {
            factoryDBcontext.FacilityGeneral.Add(facilitygeneral);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 根据ID查一般数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FacilityGeneral GetFacilityGeneralByID(string facilityNumber)
        {
            try
            {
                return factoryDBcontext.FacilityGeneral.FirstOrDefault(n => n.FacilityNumber.Contains(facilityNumber));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 删除一般数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteFacilityGeneral(int id)
        {
            FacilityGeneral facilitygeneral = factoryDBcontext.FacilityGeneral.Find(id);
            factoryDBcontext.FacilityGeneral.Remove(facilitygeneral);
            return factoryDBcontext.SaveChanges();
        }
    }
}
