using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Services
{
    using SmartFactory.Model;
    using SmartFactory.IServices;
    using MySql.Data.MySqlClient;

    /// <summary>
    /// 设备/零件实现类
    /// </summary>
    public class FacilityServices:IFacilityServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();


        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public FacilityNotMapp GetById(int id)
        {
            var i = factoryDBcontext.Database.SqlQuery<FacilityNotMapp>("call pro_getFacilitys").Where(n => n.ID.Equals(id)).FirstOrDefault();
            return i;
        }



        /// <summary>
        /// 查看设备/零件数据
        /// </summary>
        /// <returns></returns>
        public List<FacilityNotMapp> GetFacility()
        {

            var i = factoryDBcontext.Database.SqlQuery<FacilityNotMapp>("call pro_getFacilitys").ToList();
            return i;

        }

        /// <summary>
        /// 修改报警状态
        /// </summary>
        /// <param name="facility"></param>
        /// <returns></returns>
        public int UpdateSiren(int ID, int IsSiren)
        {
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@ids",ID),
                new MySqlParameter("@isSiren",IsSiren),
            };
            return factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_UpdateFacility (@ids,@isSiren)", parameters);

        }
    }
}
