using MVCExercise.Controller;
using MVCExercise.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExercise.Core
{
    public class ControllerContext
    {
        public ControllerBase Controller { get; set; }
        public RequestContext RequestContext { get; set; }
    }
}