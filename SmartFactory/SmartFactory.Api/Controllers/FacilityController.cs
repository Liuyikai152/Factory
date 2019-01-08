using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartFactory.IServices;
using SmartFactory.Model;
using SmartFactory.Services;
using Newtonsoft.Json;
namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("Facility")]
    public class FacilityController : ApiController
    {
        public IFacilityServices FacilityServices { get; set; }

        private const int PAGESIZE = 4;
        /// <summary>
        /// 查看所有零件
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFacility")]
        public string GetFacility(int  Page=1)
        {
           var  facilitiesList = FacilityServices.GetFacility();
            PageBox pagebox = new PageBox();
            pagebox.PageIndex = Page;
            pagebox.PageCount = facilitiesList.Count / PAGESIZE + (facilitiesList.Count % PAGESIZE == 0 ? 0 : 1);
            pagebox.Data = facilitiesList.Skip((Page - 1) * PAGESIZE).Take(PAGESIZE);
            var json = JsonConvert.SerializeObject(pagebox);
            return json;
        }
    }
}
