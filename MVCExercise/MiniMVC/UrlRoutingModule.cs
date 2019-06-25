using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MiniMVC
{
    /// <inheritdoc />
    /// <summary>
    /// 主要负责从当前的HTTP请求中解析出以Controller和Action名称为核心的路由数据。
    /// </summary>
    public class UrlRoutingModule:IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.PostResolveRequestCache += OnPostResolveRequestCache;
        }

        protected virtual void OnPostResolveRequestCache(object sender, EventArgs e)
        {
            HttpContextWrapper httpContext=new HttpContextWrapper(HttpContext.Current);
            //获取全局路由表的RouteDictionary对象
            RouteData routeData = RouteTable.Routes.GetRouteData(httpContext);
            if (null==routeData)
            {
                return;
            }
            RequestContext requestContext=new RequestContext
            {
                RouteData = routeData,
                HttpContext = httpContext
            };

            IHttpHandler handler = routeData.RouteHandler.GetHttpHandler(requestContext);
            httpContext.RemapHandler(handler);
        }

        public void Dispose()
        {
            
        }
    }
}
