using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWeb
{
    public abstract class RouteBase
    {
        public abstract RouteData GetRouteData(HttpContextBase httpContext);
    }
}