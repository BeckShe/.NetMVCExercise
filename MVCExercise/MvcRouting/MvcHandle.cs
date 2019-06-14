using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MvcRouting
{
    public class MvcHandle : IHttpHandler
    {
        public RequestContext RequestContext { get; private set; }

        public IControllerFactory ControllerFactory
        {
            get { return null; }
        }

        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            RouteData routeData = this.RequestContext.RouteData;
            var controller = this.ControllerFactory.CreateController(this.RequestContext, routeData.Controller);
            controller.Execute(this.RequestContext);

        }
    }
}
