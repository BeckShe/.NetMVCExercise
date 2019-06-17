using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MvcRouting
{
    public class DefaultControllerFactory:IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            RouteData routeData = requestContext.RouteData;
            string controllerType = $"{controllerName}Controller";
            IController controller;
            controller = this.CreateController(controllerType);
            if (null!=controller)
            {
                return controller;
            }
            foreach (var assembly in routeData.Assemblies)
            {
                controller = this.CreateController(controllerType, assembly);
                if (null!=controller)
                {
                    return controller;
                }

                foreach (var ns in routeData.Namespaces)
                {
                    controllerType = $"{ns}.{controllerName}Controller";
                    controller = this.CreateController(controllerType, assembly);
                    if (null!=controller)
                    {
                        return controller;
                    }
                }
            }
            throw new InvalidOperationException("Cannot locate the controller");
        }

        private IController CreateController(string controllerType,string assembly=null)
        {
            Type type = null;
            type = null==assembly ? Type.GetType(controllerType) : Assembly.Load(assembly).GetType(controllerType);
            if (null==type)
            {
                return null;

            }
            return Activator.CreateInstance(type) as IController;
        }
    }
}
