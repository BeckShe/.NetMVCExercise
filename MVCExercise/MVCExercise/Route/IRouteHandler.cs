using System.Web;
using System.Web.Routing;

namespace MVCExercise.Route
{
    public interface IRouteHandler
    {
        IHttpHandler GetHttpHandler(RequestContext requestContext);
    }
}