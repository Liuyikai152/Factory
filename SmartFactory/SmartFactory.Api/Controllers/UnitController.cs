﻿using System;
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
        public IUnitServices unitServices { get; set; }

        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public const int PAGESIZE = 2;
        [HttpGet]
        [Route("GetUnit")]
        public PageBox GetUnit(string AreaNumber, string UnitNumbers, int PageIndex = 1)
        {
            PageBox pageBox = new PageBox();
            var unitList = unitServices.GetHost();
            if (AreaNumber != null && AreaNumber != "")
            {
                unitList = unitList.Where(n => n.AreaName.Equals(AreaNumber)).ToList();
            }
            if (UnitNumbers != null && UnitNumbers != "")
            {
                unitList = unitList.Where(n => n.UnitNumber.Contains(UnitNumbers)).ToList();
            }
            pageBox.PageIndex = PageIndex;
            pageBox.PageSize = PAGESIZE;
            pageBox.PageCount = unitList.Count / PAGESIZE + (unitList.Count % PAGESIZE == 0 ? 0 : 1);
            pageBox.Data = unitList.Skip((PageIndex - 1) * PAGESIZE).Take(PAGESIZE);
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
            var pumpNotMap = unitServices.GetByID(id);
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
            var result = unitServices.DeleteUnit(id);
            return result;
        }

        /// <summary>
        /// 添加机组
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        [Route("AddUnit")]
        [HttpPost]
        public int AddUnit(Unit unit)
        {
            var result = unitServices.AddUnit(unit);
            return result;
        }

        /// <summary>
        /// 修改机组
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        [Route("UpdateUnit")]
        [HttpPost]
        public int UpdateUnit(Unit unit)
        {
            var result = unitServices.UpdateUnit(unit);
            return result;
        }


        /// <summary>
        /// 获取机组单个id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetUnitByID")]
        [HttpGet]
        public Unit GetUnitByID(int id)
        {
            var result = unitServices.GetUnitByID(id);
            return result;
        }
    }
}
