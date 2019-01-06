using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.IServices
{
   public interface IMaintenanceOrderServices
    {
        /// <summary>
        /// 添加维修工单
        /// </summary>
        /// <param name="maintenanceOrder"></param>
        /// <returns></returns>
        int AddMaintenanceOrder(MaintenanceOrder maintenanceOrder);

        /// <summary>
        /// 删除维修工单
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteMaintenanceOrder(int id);

        /// <summary>
        /// 修改维修工单
        /// </summary>
        /// <param name="maintenanceOrder"></param>
        /// <returns></returns>
        int UpdateMaintenanceOrder(MaintenanceOrder maintenanceOrder);

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        MaintenanceOrder GetById(int id);

        /// <summary>
        /// 显示维修工单
        /// </summary>
        /// <returns></returns>
        List<MaintenanceOrder> GetMaintenanceOrders();
    }
}
