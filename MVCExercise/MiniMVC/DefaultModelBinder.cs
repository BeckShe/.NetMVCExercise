using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniMVC
{
    public class DefaultModelBinder:IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, string name, Type type)
        {
            throw new NotImplementedException();
        }
    }
}
