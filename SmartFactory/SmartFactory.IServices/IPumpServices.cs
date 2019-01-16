using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.IServices
{
   public interface IPumpServices
    {
        /// <summary>
        /// 添加机泵
        /// </summary>
        /// <param name="pump"></param>
        /// <returns></returns>
        int AddPump(Pump pump);

        /// <summary>
        /// 删除机泵
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeletePump(int id);

        /// <summary>
        /// 修改机泵
        /// </summary>
        /// <param name="pump"></param>
        /// <returns></returns>
        int UpdatePump(Pump pump);

        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PumpNotMap GetByID(int id);

        /// <summary>
        /// 显示机泵
        /// </summary>
        /// <returns></returns>
        List<PumpNotMap> GetPumps();

        /// <summary>
        /// 修改报警状态
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsSiren"></param>
        /// <returns></returns>
        int UpdateSiren(int ID, int IsSiren);
    }
}
