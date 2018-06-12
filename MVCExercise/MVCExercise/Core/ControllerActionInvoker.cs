using MVCExercise.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExercise.Core
{
    public class ControllerActionInvoker : IActionInvoker
    {
        public ControllerActionInvoker()
        {

        }

        public void InvokeAction(ControllerContext controllerContext, string acitonName)
        {
            throw new NotImplementedException();
        }
    }
}