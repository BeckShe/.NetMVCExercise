using MVCExercise.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExercise.Model
{
    public class UrlRoutingModule : IHttpModule
    {
        public void Dispose()
        {
           
        }

        public void Init(HttpApplication context)
        {
            context.PostResolveRequestCache += OnPostResolveRequestCache;
        }

        protected virtual void OnPostResolveRequestCache(object sender,EventArgs e)
        {
            HttpContextWrapper httpContext = new HttpContextWrapper(HttpContext.Current);
            RouteData routeDate = RouteTable.Routes.GetRouteData(httpContext);
            if (null==routeDate)
            {
                return;
            }
            RequestContext requestContext = new RequestContext { RouteData = routeDate, HttpContext = httpContext };
            IHttpHandler handler = routeDate.RouteHandler.GetHttpHandler(requestContext);
            httpContext.RemapHandler(handler);
        }
    }
}