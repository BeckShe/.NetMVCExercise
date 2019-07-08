using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMVC
{
    public abstract class ControllerBase:IController
    {
        /// <summary>
        /// 执行Action方法接口
        /// </summary>
        protected IActionInvoker ActionInvoker { get; set; }

        public ControllerBase()
        {
            this.ActionInvoker=new ControllerActionInvoker();
        }

        public void Execute(RequestContext requestContext)
        {
            ControllerContext context = new ControllerContext {Controller = this, RequestContext = requestContext};
            string actionName = requestContext.RouteData.ActionName;
            this.ActionInvoker.InvokeAction(context,actionName);
        }
    }
}
