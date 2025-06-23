using Microsoft.AspNetCore.Builder;

namespace ZIP2Go.WebAPI.Extensions;

public static class ApplicationInsightsLoggingExtensions
{
    public static IApplicationBuilder UseApplicationInsightsLogging(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ApplicationInsightsLoggingMiddleware>();
    }
} 