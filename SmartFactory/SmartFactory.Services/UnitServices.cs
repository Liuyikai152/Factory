using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            factoryDBcontext.Unit.Remove(GetByID(id));
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 获取单个id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Unit GetByID(int id)
        {
            var i= factoryDBcontext.Unit.Find(id);
            return i;
        }

        /// <summary>
        /// 显示机组
        /// </summary>
        /// <returns></returns>
        public List<UnitNotMapped> GetHost()
        {
            var uintList= factoryDBcontext.Database.SqlQuery<UnitNotMapped>("CALL pro_Getunitlist").ToList();
            return uintList;
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
    }
}
