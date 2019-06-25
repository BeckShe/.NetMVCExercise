using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MiniMVC
{
    public interface IRouteHandler
    {
        /// <summary>
        /// 返回真正用于处理HTTP请求的HttpHandler对象
        /// </summary>
        /// <param name="requestContext">表示当前（HTTP）请求的上下文，其核心就是对当前HttpContext和RouteData的封装，这可以通过如下的代码片断看出来。</param>
        /// <returns></returns>
        IHttpHandler GetHttpHandler(RequestContext requestContext);
    }
}
