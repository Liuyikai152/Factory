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
    /// 设备位号实现类
    /// </summary>
    public class BitNumberServices:IBitNumber
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加设备位号
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        public int AddBitNumber(BitNumber bitnumber)
        {
            factoryDBcontext.BitNumber.Add(bitnumber);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 查看设备位号
        /// </summary>
        /// <returns></returns>
        public List<BitNumber> GetFacilityType()
        {
            var getBitNumber = from bitnumber in factoryDBcontext.BitNumber.ToList() select bitnumber;
            return getBitNumber.ToList();
        }
    }
}
