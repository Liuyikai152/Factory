using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SmartFactory.IServices;
using SmartFactory.Model;

namespace SmartFactory.Services
{
    public class UnitServices : IUnitServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加机组
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public int AddUnit(Unit unit)
        {
            factoryDBcontext.Unit.Add(unit);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 删除机组
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteUnit(int id)
        {
            var sid = factoryDBcontext.Unit.Find(id);
            factoryDBcontext.Unit.Remove(sid);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 获取单个id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public UnitNotMapped GetByID(int id)
        {
            var unitList = factoryDBcontext.Database.SqlQuery<UnitNotMapped>("call pro_Getunitlist").Where(n => n.ID.Equals(id)).FirstOrDefault();
            return unitList;
        }

        /// <summary>
        /// 显示机组
        /// </summary>
        /// <returns></returns>
        public List<UnitNotMapped> GetHost()
        {
            var unitList = factoryDBcontext.Database.SqlQuery<UnitNotMapped>("call pro_Getunitlist").ToList();
            return unitList;
        }

        /// <summary>
        /// 修改机组
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public int UpdateUnit(Unit unit)
        {
            factoryDBcontext.Entry(unit).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 获取机组单个id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Unit GetUnitByID(int id)
        {
            var unitList = factoryDBcontext.Database.SqlQuery<Unit>("call Pro_GetUnitId(@ids)", new MySqlParameter("@ids", id)).FirstOrDefault();
            return unitList;
        }


        /// <summary>
        /// 修改报警状态
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="IsSiren"></param>
        /// <returns></returns>
        public int UpdateUnitSiren(int ID, int IsSiren)
        {
            MySqlParameter[] parameters = new MySqlParameter[] {
                new MySqlParameter("@ids",ID),
                new MySqlParameter("@isSiren",IsSiren),
            };
            return factoryDBcontext.Database.ExecuteSqlCommand("CALL Pro_UpdateUnitIsSiren (@ids,@isSiren)", parameters);
        }
    }
}
