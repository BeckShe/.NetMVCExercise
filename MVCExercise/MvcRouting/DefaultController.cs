using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MvcRouting
{
    public class DefaultController:IController
    {
        public void Execute(RequestContext requestContext)
        {
            string action = requestContext.RouteData.Action;
            MethodInfo method = this.GetType().GetMethod(action);
            
        }
    }
}
