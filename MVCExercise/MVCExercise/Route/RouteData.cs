using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExercise.Route
{
    public class RouteData
    {
        public IDictionary<string,object> Values { get; private set; }
        public IDictionary<string,object> DataTokens { get; private set; }
        public IRouteHandler RouteHandler { get; set; }

       
    }
}