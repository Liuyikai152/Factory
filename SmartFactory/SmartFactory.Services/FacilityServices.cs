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
        public List<Facility> GetFacility()
        {

            var result = factoryDBcontext.Facility.ToList();
            return result;
            //var getFacility = from a in factoryDBcontext.Facility.ToList()
            //                  join b in factoryDBcontext.FacilityType on
            //                  a.FacilityNumber equals b.FacilityNumber
            //                  join c in factoryDBcontext.BitNumber on
            //                  a.FacilityNumber equals c.FacilityNumber 
            //                  join d in factoryDBcontext.FacilityLoca on
            //                  a.FacilityNumber equals d.FacilityNumber
            //                  join e in factoryDBcontext.Specification on
            //                  a.FacilityNumber equals e.FacilityNumber
            //                  join f in factoryDBcontext.FacilityGeneral on
            //                  a.FacilityNumber equals f.FacilityNumber 
            //                  join g in factoryDBcontext.FacilityManuFacturer on
            //                  a.FacilityNumber equals g.FacilityNumber
            //                  select a;

        }
    }
}
