using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MiniMVC
{
    public abstract class RouteBase
    {
        /// <summary>
        /// 该方法通过对以HttpContextBase对象表示的当前HTTP上下文进行解析从而获取一个RouteData对象。
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public abstract RouteData GetRouteData(HttpContextBase httpContext);
    }
}
