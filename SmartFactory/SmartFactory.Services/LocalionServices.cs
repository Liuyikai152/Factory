using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{
    /// <summary>
    /// 功能位置实现类
    /// </summary>
    public class LocalionServices : ILocalionServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 查看单个位置详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public LocationNotMapped GetLocationById(int id)
        {
            var i = factoryDBcontext.Database.SqlQuery<LocationNotMapped>("CALL Pro_GetLocaTionByID").Where(n => n.ID.Equals(id)).FirstOrDefault();
            return i;
        }

        /// <summary>
        /// 查看功能位置
        /// </summary>
        /// <returns></returns>
        public List<LocationNotMapped> GetLocations()
        {
            var locationList = factoryDBcontext.Database.SqlQuery<LocationNotMapped>("CALL Pro_GetLonTion").ToList();
            return locationList;
        }
    }
}
