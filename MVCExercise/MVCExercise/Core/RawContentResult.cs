using System;
using System.IO;

namespace MVCExercise.Controller
{
    internal class RawContentResult : ActionResult
    {
        private Action<TextWriter> callback;

        public RawContentResult(Action<TextWriter> callback)
        {
            this.callback = callback;
        }
    }
}