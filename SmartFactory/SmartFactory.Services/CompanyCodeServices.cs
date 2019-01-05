using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using SmartFactory.IServices;
using SmartFactory.Model;
using MySql.Data;
using MySql.Data.Entity;

namespace SmartFactory.Services
{
    /// <summary>
    /// 公司编号实现类
    /// </summary>
    public class CompanyCodeServices : ICompanyCodeServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 查看所有公司编号
        /// </summary>
        /// <returns></returns>
        public List<CompanyCode> GetCompanyCodes()
        {
            var companyCodeList = factoryDBcontext.Database.SqlQuery<CompanyCode>("call Pro_GetCompanyCode").ToList(); 
            return companyCodeList;
        }
    }
}
