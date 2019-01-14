
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{
    
    public class PumpServices : IPumpServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加机泵
        /// </summary>
        /// <param name="pump"></param>
        /// <returns></returns>
        public int AddPump(Pump pump)
        {
            factoryDBcontext.Pump.Add(pump);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 删除机泵
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeletePump(int id)
        {
            var getPump = factoryDBcontext.Pump.Find(id);
            factoryDBcontext.Pump.Remove(getPump);
            return factoryDBcontext.SaveChanges();
               
        }

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PumpNotMap GetByID(int id)
        {
            var pumpNotMap = factoryDBcontext.Database.SqlQuery<PumpNotMap>("call Pro_GetPumpByID").FirstOrDefault();
            return pumpNotMap;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<PumpNotMap> GetPumps()
        {
            var pumpList = factoryDBcontext.Database.SqlQuery<PumpNotMap>("call Pro_GetPumpList").ToList();
            return pumpList;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="pump"></param>
        /// <returns></returns>
        public int UpdatePump(Pump pump)
        {
            factoryDBcontext.Entry(pump).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }
    }
}
