using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SmartFactory.Model;
using SmartFactory.IServices;

namespace SmartFactory.Services
{
    /// <summary>
    /// 所属装置实现
    /// </summary>
    public class FactoryAreaServices : IFactoryAreaServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 查询所属装置
        /// </summary>
        /// <returns></returns>
        public List<FactoryArea> GetFactoryAreas()
        {
            var factoryAreaList = factoryDBcontext.Database.SqlQuery<FactoryArea>("call Pro_Getfactoryarea").ToList();
            return factoryAreaList;
        }
    }
}
