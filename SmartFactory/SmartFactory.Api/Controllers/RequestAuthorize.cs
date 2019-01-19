using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.Http;
using System.Web.Http.Controllers;
using SmartFactory.Model;
using SmartFactory.Cache;
using System.Web.Http.Filters;
using SmartFactory.IServices;
using SmartFactory.Services;


public class RequestAuthorize : AuthorizeAttribute
{
    FactoryDBcontext factoryDBcontext = new FactoryDBcontext();

    public override void OnAuthorization(HttpActionContext actionContext)
    {

        var userList = factoryDBcontext.Users.ToList();

        for (int i = 0; i < userList.Count; i++)
        {
            RedisHelper.Set("http://localhost:8066/Users/Login?userName=" + userList[i].UserName + "&passWord=" + userList[i].PassWord, "http://localhost:8066/Users/Login?userName=" + userList[i].UserName + "&passWord=" + userList[i].PassWord);
        }

        //从http请求的头里面获取身份验证信息，验证token值是否有效
        var authorization = actionContext.Request.RequestUri;

        if ((authorization != null) && (authorization != null))
        {
            //验证token值是否有效
            var encryptTicket = authorization;
            var clientinfo = RedisHelper.Get(encryptTicket.ToString());
            if (clientinfo != null)
            {
                base.IsAuthorized(actionContext);
            }
            else
            {
                // var z=RedisHelper.Set(encryptTicket.ToString(),encryptTicket.ToString());
                base.HandleUnauthorizedRequest(actionContext);
            }
        }
        else//如果取不到token值，并且不允许匿名访问，则返回未验证401
        {
            var attributes = actionContext.ActionDescriptor.GetCustomAttributes<AllowAnonymousAttribute>().OfType<AllowAnonymousAttribute>();
            bool isAnonymous = attributes.Any(a => a is AllowAnonymousAttribute);//验证当前动作是否允许匿名访问
            if (isAnonymous)
            {
                base.OnAuthorization(actionContext);
            }
            else
            {
                base.HandleUnauthorizedRequest(actionContext);
            }
        }
    }
}

