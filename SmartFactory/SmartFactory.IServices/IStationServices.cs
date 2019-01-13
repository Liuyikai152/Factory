using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.IServices
{
   public interface IStationServices
    {
        /// <summary>
        /// 添加测点
        /// </summary>
        /// <param name="station"></param>
        /// <returns></returns>
        int AddStation(Station station);

        /// <summary>
        /// 删除测点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteStation(int id);

        /// <summary>
        /// 修改测点
        /// </summary>
        /// <param name="station"></param>
        /// <returns></returns>
        int UpdateStation(Station station);

        /// <summary>
        /// 获取单个id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Station GetById(int id);

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        List<Station> GetStations(string PNumber);
    }
}
