using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.IServices
{
   public interface ISubfamilyServices
    {
        /// <summary>
        /// 添加子关系
        /// </summary>
        /// <param name="subfamily"></param>
        /// <returns></returns>
        int AddSubfamily(Subfamily subfamily);

        /// <summary>
        /// 删除子关系表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteSubfamily(int id);

        /// <summary>
        /// 修改子关系表
        /// </summary>
        /// <param name="subfamily"></param>
        /// <returns></returns>
        int UpdateSubfamily(Subfamily subfamily);

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Subfamily GetById(int id);

        /// <summary>
        /// 根据条件显示
        /// </summary>
        /// <returns></returns>
        List<Subfamily> GetSubfamilieByNumber(string  PNumber);

        /// <summary>
        /// 显示所有
        /// </summary>
        /// <returns></returns>
        List<Subfamily> GetSubfamilie();
        

        /// <summary>
        /// 显示机组子关系
        /// </summary>
        /// <param name="uNumber"></param>
        /// <returns></returns>
        List<Subfamily> GetUnitSubfamilies(string uNumber);
    }
}
