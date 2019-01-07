using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{
    public class MaintenanceOrderServices : IMaintenanceOrderServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加工单
        /// </summary>
        /// <param name="maintenanceOrder"></param>
        /// <returns></returns>
        public int AddMaintenanceOrder(MaintenanceOrder maintenanceOrder)
        {
            factoryDBcontext.MaintenanceOrder.Add(maintenanceOrder);
            return factoryDBcontext.SaveChanges();
        }

     

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MaintenanceOrderNotMap GetById(int id)
        {
            var i = factoryDBcontext.Database.SqlQuery<MaintenanceOrderNotMap>("call Pro_GetMaintenanceOrder").Where(n => n.ID.Equals(id)).FirstOrDefault() ;
            return i;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<MaintenanceOrderNotMap> GetMaintenanceOrders()
        {
            var maintenanceList = factoryDBcontext.Database.SqlQuery<MaintenanceOrderNotMap> ("call Pro_GetMaintenanceOrder").ToList();
            return maintenanceList;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="maintenanceOrder"></param>
        /// <returns></returns>
        public int UpdateMaintenanceOrder(MaintenanceOrder maintenanceOrder)
        {
            factoryDBcontext.Entry(maintenanceOrder).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }
    }
}
