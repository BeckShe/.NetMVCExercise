using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MiniMVC
{
    /// <inheritdoc />
    /// <summary>
    /// 具名的路由对象列表
    /// </summary>
    public class RouteDictionary:Dictionary<string,RouteBase>
    {
        /// <summary>
        /// 遍历集合找到与指定的HttpContextBase对象匹配的路由对象，并得到对应的RouteData。
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public RouteData GetRouteData(HttpContextBase httpContext)
        {
            foreach (var route in this.Values)
            {
                RouteData routeData = route.GetRouteData(httpContext);
                    if (null!=routeData)
                    {
                        return routeData;
                    }
            }
            return null;
        }
    }
}
