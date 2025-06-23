using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using System.Diagnostics;

namespace ZIP2Go.WebAPI.Extensions;

public class ApplicationInsightsLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly TelemetryClient _telemetryClient;

    public ApplicationInsightsLoggingMiddleware(RequestDelegate next, TelemetryClient telemetryClient)
    {
        _next = next;
        _telemetryClient = telemetryClient;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var sw = Stopwatch.StartNew();
        var requestTelemetry = context.Features.Get<RequestTelemetry>();
        
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _telemetryClient.TrackException(ex);
            throw;
        }
        finally
        {
            sw.Stop();
            
            if (requestTelemetry != null)
            {
                requestTelemetry.Duration = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
                requestTelemetry.Success = context.Response.StatusCode < 400;
                
                // Adiciona propriedades personalizadas
                requestTelemetry.Properties["RequestPath"] = context.Request.Path;
                requestTelemetry.Properties["RequestMethod"] = context.Request.Method;
                requestTelemetry.Properties["ResponseTime"] = sw.ElapsedMilliseconds.ToString();
            }
        }
    }
} 