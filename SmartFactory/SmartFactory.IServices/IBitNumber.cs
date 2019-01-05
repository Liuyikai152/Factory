using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.IServices
{
    using SmartFactory.Model;
    /// <summary>
    /// 设备位号实现类
    /// </summary>
    public interface IBitNumber
    {
        /// <summary>
        /// 添加设备位号
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        int AddBitNumber(BitNumber bitnumber);

        /// <summary>
        /// 查看设备位号
        /// </summary>
        /// <returns></returns>
        List<BitNumber> GetFacilityType();
    }
}
