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
    [RoutePrefix("LocaTion")]
    public class LocaTionController : ApiController
    {
        public ILocalionServices localionServices { get; set; }

        
        /// <summary>
        /// 查询功能位置信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        [HttpPost]
        [Route("GetLocaTions")]
        public PageBox GetLocaTions(string currentpage,string companyname)
        {
            var locaList = localionServices.GetLocations();
            if (companyname!=null)
            {
                locaList = locaList.Where(n => n.CompanyName.Contains(companyname)).ToList();
            }

            if (currentpage == null)
            {
                currentpage = "1";
            }
            
            int totlepage = locaList.Count / 3 + (locaList.Count % 3 == 0 ? 0 : 1);
            locaList = locaList.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();
            PageBox pagebox = new PageBox();
            pagebox.PageIndex = int.Parse(currentpage);
            pagebox.PageCount = totlepage;
            pagebox.Data = locaList;

            return  pagebox;
        }

        /// <summary>
        /// 查看单个位置详情
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetLocaTion")]
        public List<LocaTion> GetLocaTion()
        {
            var locaTionList = localionServices.GetLocations();
            return locaTionList;

        }
    }
}
