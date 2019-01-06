using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;

    /// <summary>
    /// 技术参数接口
    /// </summary>
    public interface ISpecificationServices
    {
        /// <summary>
        /// 添加技术参数
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        int AddSpecification(Specification specification);

        /// <summary>
        /// 根据ID查技术参数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Specification GetSpecificationByID(string facilityNumber);

        /// <summary>
        /// 删除技术参数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteSpecification(int id);
    }
}
