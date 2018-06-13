using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MVCExercise.Core
{
    internal class ActionExecutor
    {
        private static Dictionary<MethodInfo, Func<object, object[], object>> executors = new Dictionary<MethodInfo, Func<object, object[], object>>();
        private static object syncHelper = new object();
        public MethodInfo MethodInfo { get; private set; }
        public ActionExecutor(MethodInfo methodInfo)
        {
            this.MethodInfo = methodInfo;
        }
        public object Execute(object target,object[] arguments)
        {
            Func<object,object[],object> executor;
            if (!executors.TryGetValue(this.MethodInfo,out executor))
            {
                lock (syncHelper)
                {
                    if (!executors.TryGetValue(this.MethodInfo,out executor))
                    {
                        
                    }
                }
            }

        }
    }
}