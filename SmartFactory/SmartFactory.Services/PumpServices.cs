
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
            factoryDBcontext.Pump.Remove(GetByID(id));
            return factoryDBcontext.SaveChanges();
               
        }

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pump GetByID(int id)
        {
            var i = factoryDBcontext.Pump.Find(id);
            return i;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Pump> GetPumps()
        {
            var pumpList = factoryDBcontext.Pump.ToList();
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
