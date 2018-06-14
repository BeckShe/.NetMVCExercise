using System;
using System.IO;
using MVCExercise.Core;

namespace MVCExercise.Controller
{
    public class RawContentResult : ActionResult
    {
        public Action<TextWriter> callback { get; private set; }
        
        public RawContentResult(Action<TextWriter> callback)
        {
            this.callback = callback;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            this.callback(context.RequestContext.HttpContext.Response.Output);
        }
    }
}