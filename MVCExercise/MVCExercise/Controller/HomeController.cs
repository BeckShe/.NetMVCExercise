using MVCExercise.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace MVCExercise.Controller
{
    public class HomeController:ControllerBase
    {
        public ActionResult index(SimpleModel model)
        {
            Action<TextWriter> callback = writer =>
            {
                writer.Write($"Controller:{model.Controller}<br/>Action:{model.Action}");
                writer.Write($"Foo：{model.Foo}<br />Bar:{model.Bar}<br/>Baz：{model.Baz}");
            };
            return new RawContentResult(callback);
        }
    }
}