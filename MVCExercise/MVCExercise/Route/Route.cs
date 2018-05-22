using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExercise.Route
{
    public class Route:RouteBase
    {
        public IRouteHandler RouteHandler { get; set; }
        public string Url { get; set; }
        public IDictionary<string,object> DataTokens { get; set; }
        public Route()
        {
            this.DataTokens = new Dictionary<string, object>();
            this.RouteHandler = new MVCRouteHandler();
        }

        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            IDictionary<string, object> variables;
            if (this.Match)
            {

            }
        }
        protected bool Match(string requestUrl,out IDictionary<string,object> variables)
        {
            variables = new Dictionary<string, object>();
            string[] strArray1 = requestUrl.Split('/');
            string[] strArray2 = this.Url.Split('/');
            if (strArray1.Length!=strArray2.Length)
            {
                return false;
            }
            for (int i = 0; i < strArray2.Length; i++)
            {

            }
            return true;
         }
    }
}