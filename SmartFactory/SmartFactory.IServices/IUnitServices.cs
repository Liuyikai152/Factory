using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.IServices
{
   public interface IUnitServices
    {
        /// <summary>
        /// 添加机组
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        int AddUnit(Unit unit);

        /// <summary>
        /// 删除机组
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteUnit(int id);

        /// <summary>
        /// 修改机组
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        int UpdateUnit(Unit unit);

        /// <summary>
        /// 查看机组
        /// </summary>
        /// <returns></returns>
        List<UnitNotMapped> GetHost();


        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UnitNotMapped GetByID(int id);
    }
}
