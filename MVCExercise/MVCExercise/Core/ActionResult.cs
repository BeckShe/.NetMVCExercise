using MVCExercise.Core;

namespace MVCExercise.Controller
{
    public abstract class ActionResult
    {
        public abstract void ExecuteResult(ControllerContext context);
    }
}