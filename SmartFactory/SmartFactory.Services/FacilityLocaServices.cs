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
    /// 位置信息方法
    /// </summary>
    public class FacilityLocaServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加位置信息
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        public int AddSpecification(FacilityLoca facilityloca)
        {
            factoryDBcontext.FacilityLoca.Add(facilityloca);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 查看位置信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<FacilityLoca> GetFacilityloca()
        {
            var getFacilityLoca = from facilityloca in factoryDBcontext.FacilityLoca.ToList() select facilityloca;
            return getFacilityLoca.ToList();
        }

        /// <summary>
        /// 删除位置信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteFacilityLoca(int id)
        {
            FacilityLoca facilityloca = factoryDBcontext.FacilityLoca.Find(id);
            factoryDBcontext.FacilityLoca.Remove(facilityloca);
            return factoryDBcontext.SaveChanges();
        }
    }
}
