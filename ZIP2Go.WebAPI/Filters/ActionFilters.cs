using Azure;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using RestSharp;
using Service.Client;
using Service.Interfaces;
using Service.Models;

namespace ZIP2GO.WebAPI.Filters
{
    public class ActionFilter : IActionFilter
    {
        private readonly IServiceScopeFactory _services;


        public ActionFilter(IServiceScopeFactory services)
        {
            _services = services ?? throw new ArgumentNullException(nameof(services));
        }

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
                    ExecutedActionInContext(context);
                    break;

                case "DELETE":
                    ExecutedActionInContext(context);
                    break;

                case "PATCH":
                    ExecutedActionInContext(context);
                    break;

                default:
                    break;
            }
            //Codigo  : depois que a action executa
        }


        private void ExecutedActionInContext(ActionExecutedContext context)
        {
            var controller = context.RouteData.Values.FirstOrDefault(f => f.Key == "controller").Value;
            var set = ((dynamic)context.Result).Value;
            using (var scope = _services.CreateScope())
            {
                var service = scope.ServiceProvider.GetRequiredService<ICentralizedServices>();

                switch (controller)
                {
                    case "Accounts":
                        service.GetAccount(set.Id, Guid.NewGuid().ToString(), true);
                        break;
                    case "Subscriptions":
                        service.GetSubscription(set.Id, Guid.NewGuid().ToString(), true);
                        break;
                    case "Invoices":
                        service.GetInvoice(set.Id, Guid.NewGuid().ToString(), true);
                        break;
                    case "Orders":
                        service.GetOrder(set.Id, Guid.NewGuid().ToString(), true);
                        break;
                    case "Payments":
                        service.GetPayment(set.Id, Guid.NewGuid().ToString(), true);
                        break;
                    case "Products":
                        service.GetProduct(set.Id, Guid.NewGuid().ToString(), true);
                        break;
                    case "Plans":
                        service.GetPlan(set.Id, Guid.NewGuid().ToString(), true);
                        break;
                    case "Prices":
                        service.GetPrice(set.Id, Guid.NewGuid().ToString(), true);
                        break;
                    case "Refunds":
                        service.GetRefund(set.Id, Guid.NewGuid().ToString(), true);
                        break;
                    default:
                        break;
                }

            }
        }
    }
}