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
        /// 删除维修工单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteMaintenanceOrder(int id)
        {
            factoryDBcontext.MaintenanceOrder.Remove(GetById(id));
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MaintenanceOrder GetById(int id)
        {
            var i = factoryDBcontext.MaintenanceOrder.Find(id);
            return i;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<MaintenanceOrder> GetMaintenanceOrders()
        {
            var maintenanceList = factoryDBcontext.MaintenanceOrder.ToList();
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
