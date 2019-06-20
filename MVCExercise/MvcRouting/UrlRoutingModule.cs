using System.Web;

namespace MvcRouting
{
    public class UrlRoutingModule:IHttpModule
    {
        public void Dispose()
        {

        }
        public void Init(HttpApplication context)
        {
            context.PostResolveRequestCache += (sender, args) =>
            {
                HttpContextWrapper contextWrapper=new HttpContextWrapper(context.Context);
                HttpContextBase httpContext = (HttpContextBase) contextWrapper;
                RouteData routeData = RouteTable.Routes.GetRouteData(httpContext);
                if (null==routeData)
                {
                    return;
                }
                RequestContext requestContext = new RequestContext { HttpContext = httpContext, RouteData = routeData };
                httpContext.RemapHandler(routeData.RouteHandler.GetHttpHandler(requestContext));
            };
        }


    }
}