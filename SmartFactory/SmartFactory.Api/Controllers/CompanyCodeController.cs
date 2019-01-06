
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

    public class CompanyCodeController : ApiController
    {
         public ICompanyCodeServices companyCodeServices { get; set; }

        /// <summary>
        /// 查询所有公司编号
        /// </summary>
        /// <returns></returns>
        public List<CompanyCode> GetCompanyCode()
        {
            var companyCodesList= companyCodeServices.GetCompanyCodes();
            return companyCodesList;
        }
    }
}
