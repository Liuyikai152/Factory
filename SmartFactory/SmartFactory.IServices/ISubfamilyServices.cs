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
        /// 显示子关系
        /// </summary>
        /// <returns></returns>
        List<Subfamily> GetSubfamilies();
    }
}
