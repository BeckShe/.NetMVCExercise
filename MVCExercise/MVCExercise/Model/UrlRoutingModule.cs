using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExercise.Model
{
    public class UrlRoutingModule : IHttpModule
    {
        public void Dispose()
        {
           
        }

        public void Init(HttpApplication context)
        {
            context.PostResolveRequestCache += OnPostResolveRequestCache;
        }

        protected virtual void OnPostResolveRequestCache(object sender,EventArgs e)
        {

        }
    }
}