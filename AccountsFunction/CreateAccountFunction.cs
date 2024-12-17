using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ZIP2Go.Models;

namespace AccountsFunction
{
    public static class CreateAccountFunction
    {
        [FunctionName("CreateAccount")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log, AccountCreateRequest accountCreateRequest,  string zuoraTrackId, bool? _async, string zuoraEntityIds,  string idempotencyKey,  string acceptEncoding,  string contentEncoding, [FromQuery] List<string> fields, [FromQuery] List<string> subscriptionsFields, [FromQuery] List<string> subscriptionPlansFields, [FromQuery] List<string> subscriptionItemsFields, [FromQuery] List<string> invoiceOwnerAccountFields, [FromQuery] List<string> planFields, [FromQuery] List<string> paymentMethodsFields, [FromQuery] List<string> paymentsFields, [FromQuery] List<string> billingDocumentsFields, [FromQuery] List<string> billingDocumentItemsFields, [FromQuery] List<string> billToFields, [FromQuery] List<string> soldToFields, [FromQuery] List<string> defaultPaymentMethodFields, [FromQuery] List<string> usageRecordsFields, [FromQuery] List<string> invoicesFields, [FromQuery] List<string> creditMemosFields, [FromQuery] List<string> debitMemosFields, [FromQuery] List<string> prepaidBalanceFields, [FromQuery] List<string> transactionsFields, [FromQuery] List<string> expand, [FromQuery] List<string> filter, [FromQuery][Range(1, 99)] int? pageSize)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }
    }
}
