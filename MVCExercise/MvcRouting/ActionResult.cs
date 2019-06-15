using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcRouting
{
    public abstract class ActionResult
    {
        public abstract void ExectueResult(ControllerContext context);
    }
}
