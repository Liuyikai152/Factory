﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFactory.IServices;
using SmartFactory.Model;

using MySql.Data.MySqlClient;

namespace SmartFactory.Services
{
    public class SubfamilyServices : ISubfamilyServices
    {
        FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

        /// <summary>
        /// 添加子关系
        /// </summary>
        /// <param name="subfamily"></param>
        /// <returns></returns>
        public int AddSubfamily(Subfamily subfamily)
        {
            factoryDBcontext.Subfamily.Add(subfamily);
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 删除子关系
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteSubfamily(int id)
        {
            factoryDBcontext.Subfamily.Remove(GetById(id));
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 获取单个ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Subfamily GetById(int id)
        {
            var i= factoryDBcontext.Subfamily.Find(id);
            return i;
        }

        /// <summary>
        /// 根据条件显示
        /// </summary>
        /// <returns></returns>
        public List<Subfamily> GetSubfamilieByNumber(string PNumber)
        {
            var subfamilyList= factoryDBcontext.Database.SqlQuery<Subfamily>("call Pro_GetsubfamilyByNumber(@PNumber)",new MySqlParameter("@PNumber", PNumber)).ToList();
            return subfamilyList;
        }

        /// <summary>
        /// 显示所有
        /// </summary>
        /// <returns></returns>
        public List<Subfamily> GetSubfamilie()
        {
            var subfamilyList = factoryDBcontext.Database.SqlQuery<Subfamily>("call Pro_Getsubfamily").ToList();
            return subfamilyList;
        }

        /// <summary>
        /// 修改子关系
        /// </summary>
        /// <param name="subfamily"></param>
        /// <returns></returns>
        public int UpdateSubfamily(Subfamily subfamily)
        {
            factoryDBcontext.Entry(subfamily).State = System.Data.Entity.EntityState.Modified;
            return factoryDBcontext.SaveChanges();
        }

        /// <summary>
        /// 显示机组子系统列表
        /// </summary>
        /// <param name="PNumber"></param>
        /// <returns></returns>
        public List<Subfamily> GetUnitSubfamilies(string uNumber)
        {
            var subfamilyList = factoryDBcontext.Database.SqlQuery<Subfamily>("call Pro_GetUnitSubfamily(@uNumber)", new MySqlParameter("@uNumber", uNumber)).ToList();
            return subfamilyList;
        }
    }
}
