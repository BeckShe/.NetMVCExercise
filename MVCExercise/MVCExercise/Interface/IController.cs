using MVCExercise.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExercise.Interface
{
    public interface IController
    {
        void Execute(RequestContext requestContext);
    }
}
