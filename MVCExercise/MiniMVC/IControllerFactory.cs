using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMVC
{
    public interface IControllerFactory
    {
        IControllerFactory GetControllerFactory();
        /// <summary>
        /// 根据传入的请求上下文和Controller的名词来激活相应的Controller对象
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="controllerName"></param>
        /// <returns></returns>
        IController CreateController(RequestContext requestContext, string controllerName);
    }
}
