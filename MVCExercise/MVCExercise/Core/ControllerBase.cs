using MVCExercise.Core;
using MVCExercise.Interface;
using MVCExercise.Route;

namespace MVCExercise.Controller
{
    public abstract class ControllerBase :IController
    {
        protected IActionInvoker ActionInvoker { get; set; }
        public ControllerBase()
        {
            this.ActionInvoker = new ControllerActionInvoker();
        }
        public void Execute(RequestContext requestContext)
        {
            ControllerContext context = new ControllerContext { RequestContext = requestContext,Controller=this };
            string actionName = requestContext.RouteData.ActionName;
            this.ActionInvoker.InvokeAction(context, actionName);
          
        } 
    }
}