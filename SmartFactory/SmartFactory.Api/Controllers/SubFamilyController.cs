﻿using System;
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
    [RoutePrefix("SubFamily")]
    public class SubFamilyController : ApiController
    {

        public ISubfamilyServices subfamilyServices { get; set; }
        /// <summary>
        /// 根据条件显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSubfamilies")]
        public List<Subfamily> GetSubfamilies(string PNumber)
        {
            var subfamilyList = subfamilyServices.GetSubfamilieByNumber(PNumber);
            return subfamilyList;
        }

        /// <summary>
        /// 显示所有
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSubfamiliy")]
        public List<Subfamily> GetSubfamilie()
        {
            var subfamilyList = subfamilyServices.GetSubfamilie();
            return subfamilyList;
        }


        /// <summary>
        /// 显示机组子关系
        /// </summary>
        /// <param name="PNumber"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetUnitSubfamilies")]
        public List<Subfamily> GetUnitSubfamilies(string uNumber)
        {
            var subfamilyList = subfamilyServices.GetUnitSubfamilies(uNumber);
            return subfamilyList;
        }

        /// <summary>
        /// 添加子关系
        /// </summary>
        /// <param name="subfamily"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddSubfamily")]
        public int AddSubfamily(Subfamily subfamily)
        {
            var i = subfamilyServices.AddSubfamily(subfamily);
            return i;
        }

        /// <summary>
        /// 删除子关系
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("DeleteSubfamily")]
        public int DeleteSubfamily(int id)
        {
            var i = subfamilyServices.DeleteSubfamily(id);
            return i;
        }

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetById")]
        public Subfamily GetById(int id)
        {
            var subfamily = subfamilyServices.GetById(id);
            return subfamily;
        }


        /// <summary>
        /// 修改子关系
        /// </summary>
        /// <param name="subfamily"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("UpdateSubfamily")]
        public int UpdateSubfamily(Subfamily subfamily)
        {
            var i = subfamilyServices.UpdateSubfamily(subfamily);
            return i;
        }
    }
}
