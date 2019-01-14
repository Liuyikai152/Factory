using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{
    public class StationServices : IStationServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加主机/附机
        /// </summary>
        /// <param name="station"></param>
        /// <returns></returns>
        public int AddStation(Station station)
        {
            factoryDBcontext.Station.Add(station);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 删除主机/附机
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteStation(int id)
        {
            factoryDBcontext.Station.Remove(GetById(id));
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 获取单个id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Station GetById(int id)
        {
            var i= factoryDBcontext.Station.Find(id);
            return i;
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public List<Station> GetStations()
        {
            var stationList= factoryDBcontext.Station.ToList();
            return stationList;
        }


        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="station"></param>
        /// <returns></returns>
        public int UpdateStation(Station station)
        {
            factoryDBcontext.Entry(station).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }
    }
}
