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
    [RoutePrefix("Unit")]
    public class UnitController : ApiController
    {
        public IUnitServices UnitServices { get; set; }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public const int PAGESIZE = 2;
        [HttpGet]
        [Route("GetUnit")]
        public PageBox GetUnit(int PageIndex=1)
        {
            List<UnitNotMapped> Unitlist = UnitServices.GetHost();
            PageBox pageBox = new PageBox();

            pageBox.PageIndex = PageIndex;
            pageBox.PageSize = PAGESIZE;
            pageBox.PageCount = Unitlist.Count / PAGESIZE + (Unitlist.Count % PAGESIZE == 0 ? 0 : 1);
            pageBox.Data = Unitlist.Skip((PageIndex - 1) * PAGESIZE).Take(PAGESIZE);
            return pageBox;
           
        }

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetByID")]
        public UnitNotMapped GetByID(int id)
        {
            var pumpNotMap = UnitServices.GetByID(id);
            return pumpNotMap;
        }

        /// <summary>
        /// 删除机组信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("DeleteUnit")]
        [HttpGet]
        public int DeleteUnit(int id)
        {
            var result = UnitServices.DeleteUnit(id);
            return result;
        }


    }
}
