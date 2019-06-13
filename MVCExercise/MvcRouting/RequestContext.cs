using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MvcRouting
{
    public class RequestContext
    {
        public HttpContextBase HttpContext { get; set; }
        public RouteData RouteData { get; set; }
    }
}
