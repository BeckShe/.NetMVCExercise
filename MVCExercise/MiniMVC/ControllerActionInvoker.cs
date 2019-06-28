using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MiniMVC
{
    public class ControllerActionInvoker:IActionInvoker
    {
        public IModelBinder ModelBinder { get; private set; }

        public ControllerActionInvoker()
        {
            this.ModelBinder=new DefaultModelBinder();
        }

        public void InvokeAction(ControllerContext controllerContext, string actionName)
        {
            MethodInfo method = controllerContext.Controller.GetType().GetMethods()
                .First(m => string.Compare(actionName, m.Name, true) == 0);
            List<object> parameters=new List<object>();
            foreach (var parameter in method.GetParameters())
            {
                parameters.Add(this.ModelBinder.BindModel(controllerContext,parameter.Name,parameter.ParameterType));
            }
            ActionResult actionResult =
                method.Invoke(controllerContext.Controller, parameters.ToArray()) as ActionResult;
            actionResult.ExecuteResult(controllerContext);
        }
    }
}
