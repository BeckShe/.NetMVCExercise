using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Compilation;
using System.Web.Configuration;

namespace MiniMVC
{
    public class DefaultControllerFactory:IControllerFactory
    {
        private List<Type> controllerTypes=new List<Type>();

        public DefaultControllerFactory()
        {
            //System.Web.Compilation.BulidManager负责站点的动态编译，所有的页面、用户控件、和所有的ASP.NET特殊目录，都会在运行时被BuildManager编译和处理，也包括Bin目录。
            foreach (Assembly assembly in BuildManager.GetReferencedAssemblies())
            {
                foreach (Type type in assembly.GetTypes().Where(type=>typeof(IController).IsAssignableFrom(type)))
                {
                    controllerTypes.Add(type);
                }
            }
        }

        public IController CreateController(RequestContext requestContext,string controllerName)
        {
            string typeName = controllerName + "Controller";
            List<string> namespaces=new List<string>();
            namespaces.AddRange(requestContext.RouteData.Namespaces);
            namespaces.AddRange(ControllerBuilder.Current.DefaultNamespaces);
            foreach (var ns in namespaces)
            {
                string controllerTypeName = string.Format("{0}.{1}", ns, typeName);
                Type controllerType = controllerTypes.FirstOrDefault(type =>
                    string.Compare(type.FullName, controllerTypeName, true) == 0);
                if (null!=controllerType)
                {
                    return (IController) Activator.CreateInstance(controllerType);
                }
            }
            return null;
        }
    }
}
