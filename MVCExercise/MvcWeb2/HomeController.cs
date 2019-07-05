using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiniMVC;

namespace MvcWeb2
{
    public class HomeController:ControllerBase
    {
        public ActionResult Index(SimpleModel model)
        {
            string content = string.Format($"Controller:{model.Controller}<br/>Action{model.Action}");
            return new RawContentResult(content);
        }
    }
}