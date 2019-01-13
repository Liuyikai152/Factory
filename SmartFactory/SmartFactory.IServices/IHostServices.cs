using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.Model;
namespace SmartFactory.IServices
{
   public interface IHostServices
    {
        /// <summary>
        /// 添加主机/附机
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        int AddHost(Host host);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteHost(int id);

        /// <summary>
        /// 修改主机/附机
        /// </summary>
        /// <param name="host"></param>
        /// <returns></returns>
        int UpdateHost(Host host);

        /// <summary>
        /// 查看机组
        /// </summary>
        /// <returns></returns>
        List<Host> GetHost(string PNumber);


        /// <summary>
        /// 获取id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Host GetByID(int id);
    }
}
