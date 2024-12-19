using Microsoft.AspNetCore.Mvc.Filters;

namespace ZIP2Go.WebAPI.Filters
{
    public class ActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var test = context.HttpContext.Request.Method;

            switch (context.HttpContext.Request.Method)
            {
                case "POST":
                    break;
                case "PUT":
                    break;
                case "DELETE":
                    break;
                case "PATCH":
                    break;
                case "GET":
                    break;
                default:
                    break;
            }


            //Código :  antes que a action executa
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var test = context.HttpContext.Request.Method;

            switch (context.HttpContext.Request.Method)
            {
                case "POST":
                    break;
                case "PUT":
                    break;
                case "DELETE":
                    break;
                case "PATCH":
                    break;
                case "GET":
                    break;
                default:
                    break;
            }
            //Codigo  : depois que a action executa
        }
    }
}