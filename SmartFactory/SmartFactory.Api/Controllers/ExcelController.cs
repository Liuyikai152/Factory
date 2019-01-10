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

using SmartFactory.Services;
using SmartFactory.IServices;
using SmartFactory.Model;
using Newtonsoft.Json;

namespace SmartFactory.Api.Controllers
{
    [RoutePrefix("Excel")]
    public class ExcelController : ApiController
    {
        #region EXCEL导入
        /// <summary>
        /// 维修工单导入
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("ImportsExcel")]
        public int ImportsExcel()
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
                string connStr = GetConnectionString(fileName);

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
                        string stuSQL = string.Format("insert into MaintenanceOrder(OrderNumber,Belongs,DeviceNumber,DeviceName,FaultName,FaultPart,HappenTime,CompletionTime,DownTime,HandlingMethod) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",dt.Rows[i]["通知单号"],dt.Rows[i]["所属机组/机泵"],dt.Rows[i]["设备编号"],dt.Rows[i]["设备名称"],dt.Rows[i]["故障名称"],dt.Rows[i]["故障部位"],dt.Rows[i]["故障发生时间"],dt.Rows[i]["处理完成时间"],dt.Rows[i]["停机时间"],dt.Rows[i]["故障处理方法"]);
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
        #endregion

        #region 导出到EXCEL


        /// <summary>
        /// 将数据导出到指定的Excel文件中
        /// </summary>
        /// <param name="listView">System.Windows.Forms.ListView,指定要导出的数据源</param>
        /// <param name="destFileName">指定目标文件路径</param>
        /// <param name="tableName">要导出到的表名称</param>
        /// <param name="overWrite">指定是否覆盖已存在的表</param>
        /// <returns>导出的记录的行数</returns>
        [HttpPost]
        [Route("ExportToExcel")]
        public static int ExportToExcel(System.Data.DataTable dt, string destFileName, string tableName)

        {

            if (File.Exists(destFileName)) 
            {
                File.Delete(destFileName);
            }

            //得到字段名

            string szFields = "";

            string szValues = "";

            for (int i = 0; i < dt.Columns.Count; i++)

            {

                szFields += "[" + dt.Columns[i] + "],";

            }

            szFields = szFields.TrimEnd(',');

            //定义数据连接

            OleDbConnection connection = new OleDbConnection();

            connection.ConnectionString = GetConnectionString(destFileName);

            OleDbCommand command = new OleDbCommand();

            command.Connection = connection;

            command.CommandType = CommandType.Text;

            //打开数据库连接

            try

            {

                connection.Open();

            }

            catch

            {

                throw new Exception("目标文件路径错误。");

            }

            //创建数据库表

            try

            {
                command.CommandText = GetCreateTableSql("[" + tableName + "]", szFields.Split(','));
                command.ExecuteNonQuery();
            }

            catch (Exception ex)

            {

                //如果允许覆盖则删除已有数据

                throw ex;

            }

            try

            {

                //循环处理数据------------------------------------------

                int recordCount = 0;

                for (int i = 0; i < dt.Rows.Count; i++)

                {

                    szValues = "";

                    for (int j = 0; j < dt.Columns.Count; j++)

                    {

                            szValues += "'" + dt.Rows[i][j] + "',";

                        

                    }

                    szValues = szValues.TrimEnd(',');

                    //组合成SQL语句并执行

                    string szSql = "INSERT INTO [" + tableName + "](" + szFields + ") VALUES(" + szValues + ")";

                    command.CommandText = szSql;

                    recordCount += command.ExecuteNonQuery();

                }

                connection.Close();

                return recordCount;

            }

            catch (Exception ex)

            {

                throw ex;

            }

        }

        //得到连接字符串

        private static String GetConnectionString(string fullPath)

        {

            string szConnection;

            szConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fullPath + ";Extended Properties=Excel 12.0;";

            return szConnection;

        }

 

 

        //得到创建表的SQL语句

        private static string GetCreateTableSql(string tableName, string[] fields)

        {

            string szSql = "CREATE TABLE " + tableName + "(";

            for (int i = 0; i < fields.Length; i++)

            {

                szSql += fields[i] + " VARCHAR(200),";

            }

            szSql = szSql.TrimEnd(',') + ")";

            return szSql;

        }





        #endregion


        [Route("OutExcel")]
        [HttpPost]
        public  string OutExcel()
        {

            DataTable dt = GetDataTable();



            string FileName = Guid.NewGuid().ToString() + ".xls";

            string sNewFullFile = HttpContext.Current.Request.MapPath(FileName);
            try
            {
                File.Copy(HttpContext.Current.Request.MapPath("format.xls"), sNewFullFile);
            }
            catch (Exception er)
            {
                return er.Message;
                
            }

            string strConn = GetConnectionString(sNewFullFile);
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection(strConn);
            OleDbCommand cmd = null;

            bool bRet = false;
            try
            {
                conn.Open();
                cmd = new OleDbCommand("create table [sheet1]([通知单号] Text,[所属机组/机泵] Text,[设备编号] Text,[设备名称] Text,[故障名称] Text,[故障部位] Text,[故障发生时间] Text,[处理完成时间] Text,[停机时间] Text,[故障处理方法] Text)", conn);
                cmd.ExecuteNonQuery();



                string strSQL = "INSERT INTO [Sheet1$] ([通知单号], [所属机组/机泵],[设备编号],[设备名称],[故障名称],[故障部位],[故障发生时间],[处理完成时间],[停机时间],[故障处理方法]) VALUES (?, ?, ?)";

                cmd = new OleDbCommand(strSQL, conn);

                for (int i = 0; i < 3; i++)
                {
                    cmd.Parameters.Add(i.ToString(), OleDbType.VarChar);
                }



                DataView dv = dt.DefaultView;
                foreach (DataRowView row in dv)
                {

                    cmd.Parameters[0].Value = row["OrderNumber"].ToString();
                    cmd.Parameters[1].Value = (int)row["age"];
                    cmd.Parameters[2].Value = row["phone"].ToString();
                    cmd.ExecuteNonQuery();
                }
                bRet = true;


            }
            catch (Exception er)
            {
                 return er.Message;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                conn.Dispose();

            }
            if (bRet)
                return  FileName;



            return FileName;
        }

        public IMaintenanceOrderServices maintenanceOrderServices { get; set; }

        public DataTable GetDataTable() {
            var list = maintenanceOrderServices.GetMaintenanceOrders(null);

            return JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(list));

        }

    }
}
