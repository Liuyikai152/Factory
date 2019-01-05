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
        /// <param name="ID"></param>
        /// <returns></returns>
        public LocaTion GetLocation(int ID)
        {
            var locationList = factoryDBcontext.LocaTion.Find(ID);
            return locationList;
        }

        /// <summary>
        /// 查看功能位置
        /// </summary>
        /// <returns></returns>
        public List<LocaTion> GetLocations()
        {
            var locationList = factoryDBcontext.Database.SqlQuery<LocaTion>("").ToList();
            return locationList;
        }
    }
}
