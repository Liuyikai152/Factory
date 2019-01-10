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
  
    [RoutePrefix("Import")]
    public class ImportController : ApiController
    {
   
        [HttpPost]
        [Route("Imports")]
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

                using (MySqlConnection mySqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ArtLineDbContext"].ConnectionString))
                {
                    MySqlCommand mySqlCommand = new MySqlCommand();
                    mySqlCommand.Connection = mySqlConnection;
                    mySqlConnection.Open();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //获得添加的sql语句 并执行

                        string stuSQL = string.Format("insert into facility(FacilityNumber,FacilityName,BitNumber, CompanyCode,PlanFactory,MaintainFactory,FactoryArea,PlanGroup,CostConter,FacilityType,FacilityLoca,StartDate,DateChanged,BusinessLine,IsInstall,IsDelete,ServiceNumber,IsSiren) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')", dt.Rows[i]["设备编号"], dt.Rows[i]["设备名称"], dt.Rows[i]["设备位号"], dt.Rows[i]["公司编号"], dt.Rows[i]["计划工厂"], dt.Rows[i]["维护工厂"], dt.Rows[i]["工厂区域"], dt.Rows[i]["计划员组"], dt.Rows[i]["成本中心"], dt.Rows[i]["设备种类"], dt.Rows[i]["设备安装位置"], dt.Rows[i]["开始日期"], dt.Rows[i]["修改日期"], dt.Rows[i]["业务范围"], dt.Rows[i]["是否安装位置"], dt.Rows[i]["包含删除"], dt.Rows[i]["维护班组编号"], dt.Rows[i]["是否报警"]);
                        mySqlCommand.CommandText = stuSQL;
                        var addpowers = mySqlCommand.ExecuteNonQuery();
                    }
                    mySqlConnection.Close();
                }
                conn.Close();

                return 1;
            }
            else
            {
                return 0;
            }

        }

        [HttpPost]
        [Route("LocaTion")]
        public int LocaTion()
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

                using (MySqlConnection mySqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ArtLineDbContext"].ConnectionString))
                {
                    MySqlCommand mySqlCommand = new MySqlCommand();
                    mySqlCommand.Connection = mySqlConnection;
                    mySqlConnection.Open();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //获得添加的sql语句 并执行

                        string stuSQL = string.Format("insert into location(LocaNumber,LocaNamess,CompanyCode, PlanFactory,MaintainFactory,FactoryArea,PlanGroup,CostConter,LocaType,LocaState,StartDate,DateChanged,BusinessLine,IsInstall,IsDelete,ServiceNumber) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", dt.Rows[i]["位置编码"], dt.Rows[i]["关联位置"], dt.Rows[i]["公司编号"], dt.Rows[i]["计划工厂"], dt.Rows[i]["维护工厂"], dt.Rows[i]["工厂区域"], dt.Rows[i]["计划员组"], dt.Rows[i]["成本中心"], dt.Rows[i]["位置类型"], dt.Rows[i]["位置状态"], dt.Rows[i]["开始日期"], dt.Rows[i]["修改日期"], dt.Rows[i]["业务范围"], dt.Rows[i]["是否安装"], dt.Rows[i]["包含删除"], dt.Rows[i]["维护班组"]);
                        mySqlCommand.CommandText = stuSQL;
                        var addpowers = mySqlCommand.ExecuteNonQuery();
                    }
                    mySqlConnection.Close();
                }
                conn.Close();

                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
