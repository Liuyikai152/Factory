using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using SmartFactory.IServices;
using SmartFactory.Model;
using SmartFactory.Services;
namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("Facility")]
    public class FacilityController : ApiController
    {
        public IFacilityServices FacilityServices { get; set; }
        /// <summary>
        /// 查看所有零件
        /// </summary>
        /// <returns></returns>
        public const int PAGESIZE = 2;
        [HttpGet]
        [Route("GetFacility")]
        public PageBox GetFacility(int PageIndex = 1)
        {      
            PageBox pageBox = new PageBox();
            List<FacilityNotMapp> facility = FacilityServices.GetFacility();
            pageBox.PageIndex = PageIndex;
            pageBox.PageSize = PAGESIZE;
            pageBox.PageCount = facility.Count / PAGESIZE + (facility.Count % PAGESIZE == 0 ? 0 : 1);
            pageBox.Data = facility.Skip((PageIndex - 1) * PAGESIZE).Take(PageIndex);
            return pageBox;
            
        }
        
        /// <summary>
        /// 根据ID查一个
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetById")]
        public FacilityNotMapp GetById(int id)
        {

            var falist = FacilityServices.GetById(id);
            return falist;

           

        }
        

    }
}
