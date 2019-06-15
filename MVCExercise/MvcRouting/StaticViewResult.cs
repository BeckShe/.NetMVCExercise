using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcRouting
{
    public class StaticViewResult : ActionResult
    {
        public override void ExectueResult(ControllerContext context)
        {
            context.RequestContext.HttpContext.Response.WriteFile(context.RequestContext.RouteData.Action + ".html");

        }
    }
}
