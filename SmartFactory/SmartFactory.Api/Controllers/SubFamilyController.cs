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
        /// 显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSubfamilies")]
        public List<Subfamily> GetSubfamilies(string PNumber)
        {
            var subfamilyList = subfamilyServices.GetSubfamilies(PNumber);
            return subfamilyList;
        }
    }
}