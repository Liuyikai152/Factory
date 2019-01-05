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
    /// 技术参数实现类
    /// </summary>
    public class SpeciFicationServices:ISpecification
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加技术参数
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        public int AddSpecification(Specification specification)
        {
            factoryDBcontext.Specification.Add(specification);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 根据ID查技术参数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Specification GetSpecificationByID(string facilityNumber)
        {
            try
            {
                return factoryDBcontext.Specification.FirstOrDefault(n => n.FacilityNumber.Contains(facilityNumber));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 删除技术参数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteSpecification(int id)
        {
            Specification specification = factoryDBcontext.Specification.Find(id);
            factoryDBcontext.Specification.Remove(specification);
            return factoryDBcontext.SaveChanges();
        }
    }
}
