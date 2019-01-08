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

<<<<<<< HEAD
        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FacilityNotMapp GetById(int id)
        {
            var i = factoryDBcontext.Database.SqlQuery<FacilityNotMapp>("call pro_getFacilitys").Where(n => n.ID.Equals(id)).FirstOrDefault();
            return i;
        }


        /// <summary>
        /// 查看设备/零件数据
        /// </summary>
        /// <returns></returns>
        public List<FacilityNotMapp> GetFacility()
        {
            var acilityList = factoryDBcontext.Database.SqlQuery<FacilityNotMapp>("CALL pro_getFacilitys").ToList();
            return acilityList;
        }

       
         
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
