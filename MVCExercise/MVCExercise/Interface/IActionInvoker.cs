using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCExercise.Core;

namespace MVCExercise.Interface
{
    public interface IActionInvoker
    {
        void InvokeAction(ControllerContext controllerContext, string acitonName);
    }
}
