using Azure;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using RestSharp;
using Service.Client;
using Service.Interfaces;
using Service.Models;
using ZIP2GO.Repository.Models;

namespace ZIP2GO.WebAPI.Filters
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

                    ExecutedActionInContext(context);

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

        private void ExecutedActionInContext(ActionExecutedContext context)
        {
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


            //var controller = context.RouteData.Values.FirstOrDefault(f=>f.Key == "controller").Value;

            //switch (controller)
            //{
            //    case "Products":
            //        var set = ((dynamic)context.Result).Value;
            //        var path = "v2/products/{product_id}";
            //        path = path.Replace("{format}", "json");
            //       // path = path.Replace("{" + "product_id" + "}", _apiClient.ParameterToString(set.Id));
            //       //  _apiClient.CallApi<ProductCreateRequest>(set.Id, path, Method.Get, null, JsonConvert.SerializeObject(set));
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}