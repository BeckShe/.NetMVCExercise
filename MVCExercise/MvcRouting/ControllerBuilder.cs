using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcRouting
{
    public class ControllerBuilder
    {
        static ControllerBuilder()
        {
            Current=new ControllerBuilder();
        }
        private static readonly IControllerFactory ControllerFactory=new DefaultControllerFactory();
        public static ControllerBuilder Current { get; }

        public IControllerFactory GetControllerFactory()
        {
            return ControllerFactory;
        }
       
    }
}
