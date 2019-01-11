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
    /// 审批流程配置实现类
    /// </summary>
    public class ConfigurationServices:IConfigurationsServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加审批流程配置
        /// </summary>
        /// <param name="facilitymanu"></param>
        /// <returns></returns>
        public int AddConfiguration(Configuration configuration)
        {
            factoryDBcontext.Configurations.Add(configuration);
            return factoryDBcontext.SaveChanges();
        }
        
        /// <summary>
        /// 查看审批活动
        /// </summary>
        /// <returns></returns>
        public List<ConfigurationNotMapped> Getfiguration()
        {
            var configurationList = factoryDBcontext.Database.SqlQuery<ConfigurationNotMapped>("CALL Pro_GetConfiguration").ToList();
            return configurationList;
        }

        /// <summary>
        /// 删除审批活动
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteConfiguration(int id)
        {
            Configuration configuration = factoryDBcontext.Configurations.Find(id);
            factoryDBcontext.Configurations.Remove(configuration);
            return factoryDBcontext.SaveChanges();
        }


    }
}
