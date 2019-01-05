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
    /// 制造商实现类
    /// </summary>
    public class FacilityManuFacturerServices:IFacilityManuFacturer
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加制造商
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        public int AddFacilityManu(FacilityManuFacturer facilitymanu)
        {
            factoryDBcontext.FacilityManuFacturer.Add(facilitymanu);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 根据ID查制造商
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FacilityManuFacturer GetWareHouseByID(string facilityNumber)
        {
            try
            {
                return factoryDBcontext.FacilityManuFacturer.FirstOrDefault(n => n.FacilityNumber.Contains(facilityNumber));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 删除制造商
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteFacilityManu(int id)
        {
            FacilityManuFacturer facilitymanu = factoryDBcontext.FacilityManuFacturer.Find(id);
            factoryDBcontext.FacilityManuFacturer.Remove(facilitymanu);
            return factoryDBcontext.SaveChanges();
        }

    }
}
