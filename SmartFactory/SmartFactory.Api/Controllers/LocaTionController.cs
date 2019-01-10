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
        public PageBox GetLocaTions(FactoryEnum locastate,string  isdelete,string currentpage,string companyname,string locanumber,string factoryname1,string factoryname2)
        {
            if (currentpage == null)
            {
                currentpage = "1";
            }

            var rolelist = localionServices.GetLocations();
            if (locastate != 0)
            {
                rolelist = rolelist.Where(n => n.LocaState.Equals(locastate)).ToList();
            }
            if (isdelete != null)
            {
                if (isdelete == "true")
                {
                    isdelete = "1";
                }
                else {
                    isdelete = "0";
                }
                rolelist = rolelist.Where(n => n.IsDelete.Equals(Convert.ToInt32(isdelete))).ToList();
            }
            if (companyname != null)
            {
                rolelist = rolelist.Where(n => n.CompanyName.Contains(companyname)).ToList();
            }
            if (locanumber != null)
            {
                rolelist = rolelist.Where(n => n.LocaNumber.Contains(locanumber)).ToList();
            }
            if (factoryname1 != null)
            {
                rolelist = rolelist.Where(n => n.FactoryName1.Contains(factoryname1)).ToList();
            }
            if (factoryname2 != null)
            {
                rolelist = rolelist.Where(n => n.FactoryName2.Contains(factoryname2)).ToList();
            }
           
            int totlepage = rolelist.Count / 3 + (rolelist.Count % 3 == 0 ? 0 : 1);
            rolelist = rolelist.Skip((int.Parse(currentpage) - 1) * 3).Take(3).ToList();
            PageBox pagebox = new PageBox();
            pagebox.PageIndex = int.Parse(currentpage);
            pagebox.PageCount = totlepage;
            pagebox.Data = rolelist;

            return pagebox;
        }

        /// <summary>
        /// 查看单个位置详情
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetLocationById")]
        public LocationNotMapped GetLocationById(int id)
        {
            var i = localionServices.GetLocationById(id);
            return i;
        }
    }
}
