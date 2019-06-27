using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web.Compilation;
using System.Web.Configuration;

namespace MiniMVC
{
    /// <summary>
    /// 默认工厂类型
    /// </summary>
    public class DefaultControllerFactory:IControllerFactory
    {
        /// <summary>
        /// 满足条件的控制器类型集合
        /// </summary>
        private List<Type> controllerTypes=new List<Type>();

        public DefaultControllerFactory()
        {
            //System.Web.Compilation.BulidManager负责站点的动态编译，所有的页面、用户控件、和所有的ASP.NET特殊目录，都会在运行时被BuildManager编译和处理，也包括Bin目录。
            foreach (Assembly assembly in BuildManager.GetReferencedAssemblies())
            {
                //查找所有继承了IController的类
                foreach (Type type in assembly.GetTypes().Where(type=>typeof(IController).IsAssignableFrom(type)))
                {
                    controllerTypes.Add(type);
                }
            }
        }

        //public IControllerFactory GetControllerFactory()
        //{
        //    throw new NotImplementedException();
        //}
        /// <summary>
        /// 创建激活控制器
        /// </summary>
        /// <param name="requestContext">请求上下文</param>
        /// <param name="controllerName">控制器名称</param>
        /// <returns></returns>
        public IController CreateController(RequestContext requestContext,string controllerName)
        {
            //控制器名称
            string typeName = controllerName + "Controller";
            //命名空间集合
            List<string> namespaces=new List<string>();
            //命名空间来源-路由
            namespaces.AddRange(requestContext.RouteData.Namespaces);
            //命名空间来源-默认命名空间列表
            namespaces.AddRange(ControllerBuilder.Current.DefaultNamespaces);
            //遍历命名空间
            foreach (var ns in namespaces)
            {
                //组合成新的名称命名空间.控制器
                string controllerTypeName = string.Format("{0}.{1}", ns, typeName);
                //从满足条件的控制器类中获取和当前名称一致的控制器类
                Type controllerType = controllerTypes.FirstOrDefault(type =>
                    string.Compare(type.FullName, controllerTypeName, true) == 0);
                if (null!=controllerType)
                {
                    //创建并返回
                    return (IController) Activator.CreateInstance(controllerType);
                }
            }
            return null;
        }
    }
}
