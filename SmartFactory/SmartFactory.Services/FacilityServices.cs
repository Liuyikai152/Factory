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
    /// 设备/零件实现类
    /// </summary>
    public class FacilityServices:IFacilityServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 查看设备/零件数据
        /// </summary>
        /// <returns></returns>
        public List<FacilityNotMapp> GetFacility()
        {
            var facilitylist = factoryDBcontext.Database.SqlQuery<FacilityNotMapp>("CALL pro_getFacilitys").ToList();
            return facilitylist;
        }
    }
}
