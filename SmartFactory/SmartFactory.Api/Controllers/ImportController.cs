using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data.OleDb;
using System.Data;
using SmartFactory.IServices;
using SmartFactory.Services;
using SmartFactory.Model;
using System.Configuration;
using System.Web;


namespace SmartFactory.Api.Controllers
{
    public class ImportController : ApiController
    {
        public int Imports()
        {
            FactoryDBcontext dBcontext = new FactoryDBcontext();
            //获取所选文件
            HttpPostedFile getFile = HttpContext.Current.Request.Files["Excel"];
            if (getFile != null)
            {
                //获得所选文件名
                string fileName = HttpContext.Current.Request.MapPath("~/Content/") + getFile.FileName;
                if (!System.IO.File.Exists(fileName))
                    getFile.SaveAs(fileName);
                //把Excel当做数据源连接
                string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=Excel 12.0;";
                //打开Excel
                OleDbConnection conn = new OleDbConnection(connStr);
                conn.Open();
                //查询Excel
                string sql = "select * from [Sheet1$]";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                //初始化适配器
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                //获取查出来的Excel表
                adapter.SelectCommand = cmd;
                //初始化dataset并通过适配器赋值
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];
                Facility facility = new Facility();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    /// 设备编号
                    facility.FacilityNumber = dt.Rows[i]["设备编号"].ToString();
                    /// 设备名称
                    facility.FacilityName = dt.Rows[i]["设备名称"].ToString();
                    /// 设备位号
                    facility.BitNumber = dt.Rows[i]["设备位号"].ToString();
                    /// 公司编号
                    facility.CompanyCode = dt.Rows[i]["公司编号"].ToString();
                    /// 计划工厂
                    facility.PlanFactory = dt.Rows[i]["计划工厂"].ToString();
                    /// 维护工厂
                    facility.MaintainFactory = dt.Rows[i]["维护工厂"].ToString();
                    /// 工厂区域
                    facility.FactoryArea = dt.Rows[i]["工厂区域"].ToString();
                    /// 计划员组
                    facility.PlanGroup = dt.Rows[i]["计划员组"].ToString();
                    /// 成本中心
                    facility.CostConter = dt.Rows[i]["成本中心"].ToString();
                    /// 开始日期
                    facility.StartDate =Convert.ToDateTime(dt.Rows[i]["开始日期"]);
                    /// 修改日期
                    facility.DateChanged = Convert.ToDateTime(dt.Rows[i]["修改日期"]);
                    /// 业务范围
                    facility.BusinessLine = dt.Rows[i]["业务范围"].ToString();
                    /// 是否安装位置
                    facility.IsInstall = Convert.ToInt32(dt.Rows[i]["是否安装位置"]);
                    /// 包含删除
                    facility.IsDelete = Convert.ToInt32(dt.Rows[i]["包含删除"]);
                    /// 维护班组编号
                    facility.ServiceNumber = dt.Rows[i]["维护班组"].ToString();
                    /// 是否报警
                    facility.IsSiren = Convert.ToInt32(dt.Rows[i]["设备种类"]); 
                    /// 设备种类
                    facility.FacilityType = dt.Rows[i]["设备种类"].ToString();
                    /// 设备安装位置
                    facility.FacilityLoca = dt.Rows[i]["设备安装位置"].ToString();
        // dt.Rows[i]["设备编号"], dt.Rows[i]["设备名称"], dt.Rows[i]["设备位号"], dt.Rows[i]["公司编号"], dt.Rows[i]["计划工厂"], dt.Rows[i]["维护工厂"], dt.Rows[i]["工厂区域"], dt.Rows[i]["计划员组"], dt.Rows[i]["成本中心"], dt.Rows[i]["设备种类"], dt.Rows[i]["设备安装位置"], dt.Rows[i]["开始日期"], dt.Rows[i]["修改日期"], dt.Rows[i]["业务范围"], dt.Rows[i]["是否安装位置"], dt.Rows[i]["包含删除"], dt.Rows[i]["维护班组编号"], dt.Rows[i]["是否报警"]);

    }
                #region ado.net
                //using (MySqlConnection mySqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connString"].ConnectionString))
                //{
                //    MySqlCommand mySqlCommand = new MySqlCommand();
                //    mySqlCommand.Connection = mySqlConnection;
                //    for (int i = 0; i < dt.Rows.Count; i++)
                //    {
                //        //获得添加的sql语句 并执行

                //        string stuSQL = string.Format("insert into facility(FacilityNumber,FacilityName,BitNumber, CompanyCode,PlanFactory,MaintainFactory,FactoryArea,PlanGroup,CostConter,FacilityType,FacilityLoca,StartDate,DateChanged,BusinessLine,IsInstall,IsDelete,ServiceNumber,IsSiren) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')", dt.Rows[i]["设备编号"], dt.Rows[i]["设备名称"], dt.Rows[i]["设备位号"], dt.Rows[i]["公司编号"], dt.Rows[i]["计划工厂"], dt.Rows[i]["维护工厂"], dt.Rows[i]["工厂区域"], dt.Rows[i]["计划员组"], dt.Rows[i]["成本中心"],dt.Rows[i]["设备种类"], dt.Rows[i]["设备安装位置"], dt.Rows[i]["开始日期"], dt.Rows[i]["修改日期"], dt.Rows[i]["业务范围"], dt.Rows[i]["是否安装位置"], dt.Rows[i]["包含删除"], dt.Rows[i]["维护班组编号"], dt.Rows[i]["是否报警"]);
                //        mySqlCommand.CommandText = stuSQL;
                //        var addpowers = mySqlCommand.ExecuteNonQuery();

                //    }

                //}
                //conn.Close();
                #endregion
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
