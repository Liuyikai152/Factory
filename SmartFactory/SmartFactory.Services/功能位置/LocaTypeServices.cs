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
    /// 位置类型实现类
    /// </summary>
    public class LocaTypeServices : ILocaTypeServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 查看位置类型
        /// </summary>
        /// <returns></returns>
        public List<LocaType> GetLocaTypes()
        {
            var  locaTypeList = factoryDBcontext.Database.SqlQuery<LocaType>("").ToList();
            return locaTypeList;
        }

     
    }
}
