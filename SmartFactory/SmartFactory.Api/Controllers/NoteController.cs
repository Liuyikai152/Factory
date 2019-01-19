﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



using System.Text;
using System.IO;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Web;

namespace SmartFactory.Api.Controllers
{

    [RoutePrefix("Note")]
    public class NoteController : ApiController
    {

        #region 程序配置参数区       
        //接口测试地址（未上线前测试环境使用）
        private static String url = "http://www.etuocloud.com/gatetest.action";
        //应用 app_key
        private static String APP_KEY = "5jQ6uM8WM68e3KWdLQ3aPSsA4AipW9qH";
        //应用 app_secret
        private static String APP_SECRET = "EXOYeESEDchol6lvRFbqy6CQYG9XrjWxP3vUIt7oShTK6b3SSyergvoXHF2qQ8V0";
        //接口响应格式 json或xml
        private static String FORMAT = "json";
        #endregion

        /// <summary>
        /// 发生模板短信
        /// </summary>
        /// <param name="to">手机号</param>
        /// <param name="template">短信模板ID</param>
        /// <param name="param">模板中的参数，以英文逗号分隔</param>
        /// <returns></returns>
        [Route("sendSmsTpl")]
        [HttpPost]
        public  string sendSmsTpl(string to, int template, string param)
        {
            NameValueCollection parameters = new NameValueCollection();
            parameters.Add("app_key", APP_KEY);
            parameters.Add("view", FORMAT);
            parameters.Add("method", "cn.etuo.cloud.api.sms.template");
            parameters.Add("out_trade_no", "");//商户订单号，可空
            parameters.Add("to", to);
            parameters.Add("template", template.ToString());
            parameters.Add("params", param);
            parameters.Add("sign", getsign(parameters));
            return HttpClient.HttpPost(url, parameters);
        }

        /// <summary>
        /// 获取param签名
        /// </summary>
        /// <param name="sParams"></param>
        /// <returns></returns>
        private static string getsign(NameValueCollection parameters)
        {
            SortedDictionary<string, string> sParams = new SortedDictionary<string, string>();
            foreach (string key in parameters.Keys)
            {
                sParams.Add(key, parameters[key]);
            }

            string sign = string.Empty;
            StringBuilder codedString = new StringBuilder();
            foreach (KeyValuePair<string, string> temp in sParams)
            {
                if (temp.Value == "" || temp.Value == null || temp.Key.ToLower() == "sign")
                {
                    continue;
                }

                if (codedString.Length > 0)
                {
                    codedString.Append("&");
                }
                codedString.Append(temp.Key.Trim());
                codedString.Append("=");
                codedString.Append(temp.Value.Trim());
            }

            // 应用key
            codedString.Append(APP_SECRET);
            string signkey = codedString.ToString();
            sign = GetMD5(signkey, "utf-8");

            return sign;
        }
        //md5
        private static string GetMD5(string encypStr, string charset)
        {
            string retStr;
            MD5CryptoServiceProvider m5 = new MD5CryptoServiceProvider();

            //创建md5对象
            byte[] inputBye;
            byte[] outputBye;

            //使用XXX编码方式把字符串转化为字节数组．
            try
            {
                inputBye = Encoding.GetEncoding(charset).GetBytes(encypStr);
            }
            catch (Exception)
            {
                inputBye = System.Text.Encoding.UTF8.GetBytes(encypStr);
            }
            outputBye = m5.ComputeHash(inputBye);

            retStr = System.BitConverter.ToString(outputBye);
            retStr = retStr.Replace("-", "").ToUpper();

            //  return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(ConvertString, "MD5").ToLower(); ;

            return retStr;
        }

        public class HttpClient
        {
            /// <summary>
            /// POST请求与获取结果  
            /// </summary>
            /// <param name="Url"></param>
            /// <param name="parameters"></param>
            /// <returns></returns>
            public static string HttpPost(string Url, NameValueCollection parameters)
            {
                return HttpPost(Url, toParaData(parameters));
            }



            //调用http接口,接口编码为utf-8
            private static string toParaData(NameValueCollection parameters)
            {

                //设置参数，并进行URL编码
                StringBuilder codedString = new StringBuilder();
                foreach (string key in parameters.Keys)
                {
                    // codedString.Append(HttpUtility.UrlEncode(key));
                    codedString.Append(key);
                    codedString.Append("=");
                    codedString.Append(HttpUtility.UrlEncode(parameters[key], System.Text.Encoding.UTF8));
                    codedString.Append("&");
                }
                string paraUrlCoded = codedString.Length == 0 ? string.Empty : codedString.ToString().Substring(0, codedString.Length - 1);


                return paraUrlCoded;
            }


            /// <summary>  
            /// POST请求与获取结果  
            /// </summary>  
            public static string HttpPost(string Url, string postDataStr)
            {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded;charset=utf-8";

                //request.ContentLength = postDataStr.Length;
                //StreamWriter writer = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.UTF8);
                // writer.Write(postDataStr);
                // writer.Flush();


                //将URL编码后的字符串转化为字节
                byte[] payload = System.Text.Encoding.UTF8.GetBytes(postDataStr);
                request.ContentLength = payload.Length;
                Stream writer = request.GetRequestStream();
                writer.Write(payload, 0, payload.Length);
                writer.Close();

                //获得响应流
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                string encoding = response.ContentEncoding;
                if (encoding == null || encoding.Length < 1)
                {
                    encoding = "UTF-8"; //默认编码  
                }
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(encoding));

                string retString = reader.ReadToEnd();
                return retString;
            }



        }
    }
}
