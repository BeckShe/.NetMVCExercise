using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMVC
{
    public class ControllerContext
    {
        public ControllerBase Controller { get; set; }
        public RequestContext RequestContext { get; set; }
        public ControllerContext(RequestContext RequestContext,ControllerBase Controller)
        {
            

        }

    }
}
