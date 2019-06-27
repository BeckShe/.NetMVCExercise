using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMVC
{
    public interface IActionInvoker
    {
        void InvokeAction(ControllerContext context,string actionName);
    }
}
