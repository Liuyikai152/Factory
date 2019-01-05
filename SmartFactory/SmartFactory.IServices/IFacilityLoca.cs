using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;

    /// <summary>
    /// 设备位置接口
    /// </summary>
    public interface IFacilityLoca
    {
        /// <summary>
        /// 添加位置信息
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        int AddFacilityLoca(FacilityLoca facilityloca);

        /// <summary>
        /// 查看位置信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<FacilityLoca> GetFacilityLoca();

        /// <summary>
        /// 删除位置信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteFacilityLoca(int id);
    }
}
