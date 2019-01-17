using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartFactory.IServices;
using SmartFactory.Services;
using SmartFactory.Model;

namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("Station")]
    public class StationController : ApiController
    {
        public IStationServices stationServices { get; set; }
        public const int PAGESIZE = 3;
        /// <summary>
        /// 显示测点机泵
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStations")]
        public List<Station> GetStations(string PNumber)
        {
            var stationList = stationServices.GetStations(PNumber);
            return stationList;
        }


        /// <summary>
        /// 显示测点机组
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUnitStations")]
        public List<Station> GetUnitStations(string uNumber)
        {
            var stationList = stationServices.GetUnitStations(uNumber);
            return stationList;
        }

        /// <summary>
        /// 添加测点
        /// </summary>
        /// <param name="station"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddStation")]
        public int AddStation(Station station)
        {
            station.DateChanged = DateTime.Now;
            station.StartDate = DateTime.Now;
            var i = stationServices.AddStation(station);
            return i;
        }

        /// <summary>
        /// 删除测点
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteStation")]
        public int DeleteStation(int id)
        {
            var i = stationServices.DeleteStation(id);
            return i;
        }

        /// <summary>
        /// 获取单个id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetById")]
        public Station GetById(int id)
        {
            var station = stationServices.GetById(id);
            return station;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="station"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateStation")]
        public int UpdateStation(Station station)
        {
            station.DateChanged = DateTime.Now;
            station.StartDate = DateTime.Now;
            var i = stationServices.UpdateStation(station);
            return i;
        }

        /// <summary>
        /// 显示测点
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetStation")]
        public PageBox GetStation(int page=1)
        {
            var stationList = stationServices.GetStation();
            PageBox pageBox = new PageBox();
            pageBox.PageIndex = page;
            pageBox.PageSize = PAGESIZE;
            pageBox.PageCount = stationList.Count / PAGESIZE + (stationList.Count % PAGESIZE == 0 ? 0 : 1);
            pageBox.Data = stationList.Skip((page - 1) * PAGESIZE).Take(PAGESIZE);
            return pageBox;
        }
    }
}
