using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SmartFactory.Model;
using SmartFactory.IServices;

namespace SmartFactory.Services
{
    public class FactoryAreaServices : IFactoryAreaServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();
        public List<FactoryArea> GetFactoryAreas()
        {
            var factoryAreaList = factoryDBcontext.Database.SqlQuery<FactoryArea>("").ToList();
            return factoryAreaList;
        }
    }
}
