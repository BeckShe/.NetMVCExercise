using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MvcWeb
{
    public class RouteData
    {
        public string Controller { get; set; }

        public string Action { get; set; }

        public IList<string> Assemblies { get; set; }

        public IRouteHandler RouteHandler { get; set; }

        public RouteData(string controller, string action, IRouteHandler routeHandler)
        {
            this.Controller = controller;
            this.Action = action;
            this.RouteHandler = routeHandler;
        }
    }
}