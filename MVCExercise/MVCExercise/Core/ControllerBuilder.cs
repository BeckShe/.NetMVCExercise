using MVCExercise.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExercise.Core
{
    public class ControllerBuilder
    {
        private Func<IControllerFactory> factoryThunk;
        public static ControllerBuilder Current { get; private set; }

        static ControllerBuilder()
        {
            Current = new ControllerBuilder();
        }
        public IControllerFactory GetControllerFactory()
        {
            return factoryThunk();
        }
        public void SetControllerFactory(IControllerFactory controllerFactory)
        {
            factoryThunk=() => controllerFactory;
        }
    }
}