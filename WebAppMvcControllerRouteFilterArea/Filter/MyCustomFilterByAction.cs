using System.Web.Mvc;

namespace WebAppMvcControllerRouteFilterArea.Filter
{
    public class MyCustomFilterByAction : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            WebAppMvcControllerRouteFilterArea.Controllers.CustomFilterController.log.Clear();
            WebAppMvcControllerRouteFilterArea.Controllers.CustomFilterController.log.
                Add("exec-1 MyCustomFilterByAction OnActionExecuting");
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            WebAppMvcControllerRouteFilterArea.Controllers.CustomFilterController.log.
                Add("exec-2 MyCustomFilterByAction OnActionExecuted");
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            WebAppMvcControllerRouteFilterArea.Controllers.CustomFilterController.log.
                Add("exec-3 MyCustomFilterByAction OnResultExecuting");
        }

        /// <summary>
        /// exec after render page
        /// </summary>
        /// <param name="resultContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            WebAppMvcControllerRouteFilterArea.Controllers.CustomFilterController.log.
                Add("exec-4 MyCustomFilterByAction OnResultExecuted");
        }
    }
}