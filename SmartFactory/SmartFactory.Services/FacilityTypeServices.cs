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
    /// 设备种类实现类
    /// </summary>
    public class FacilityTypeServices:IFacilityType
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加设备种类
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        public int AddFacilityType(FacilityType facilitytype)
        {
            factoryDBcontext.FacilityType.Add(facilitytype);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 查看设备种类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<FacilityType> GetFacilityType()
        {
            var getFacilityType = from facilitytype in factoryDBcontext.FacilityType.ToList() select facilitytype;
            return getFacilityType.ToList();
        }

        /// <summary>
        /// 删除设备种类
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteFacilityType(int id)
        {
            FacilityType facilitytype = factoryDBcontext.FacilityType.Find(id);
            factoryDBcontext.FacilityType.Remove(facilitytype);
            return factoryDBcontext.SaveChanges();
        }
    }
}
