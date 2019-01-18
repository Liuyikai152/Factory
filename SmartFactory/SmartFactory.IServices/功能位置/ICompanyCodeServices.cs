using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SmartFactory.Model;

namespace SmartFactory.IServices
{
    /// <summary>
    /// 公司编号接口
    /// </summary>
   public  interface ICompanyCodeServices
    {
        /// <summary>
        /// 查询所有公司编号
        /// </summary>
        /// <returns></returns>
        List<CompanyCode> GetCompanyCodes();
    }
}
