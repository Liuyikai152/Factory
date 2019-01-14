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

        /// <summary>
        /// 显示测点
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
        /// 显示测点
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUnitStations")]
        public List<Station> GetUnitStations(string uNumber)
        {
            var stationList = stationServices.GetUnitStations(uNumber);
            return stationList;
        }
    }
}
