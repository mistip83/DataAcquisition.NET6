using DataAcquisition.Core.Models.Utilities;
using Microsoft.AspNetCore.Diagnostics;
using Newtonsoft.Json;

namespace DataAcquisition.API.Extensions;

/// <summary>
/// The global error handler is used catch all errors and remove the need for duplicated error handling code throughout the .NET api.
/// It's configured as middleware in the Configure method of the project startup file
/// </summary>
public static class CustomErrorHandler
{
    public static void UseCustomGlobalErrorHandler(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(config =>
        {
            config.Run(async context =>
            {
                context.Response.StatusCode = 500;
                context.Response.ContentType = "application/json";
                var error = context.Features.Get<IExceptionHandlerFeature>();
                if (error != null)
                {
                    var ex = error.Error;
                    var errorDto = new ErrorMessage { Status = 500 };
                    errorDto.Errors.Add(ex.Message);

                    await context.Response.WriteAsync(JsonConvert.SerializeObject(errorDto));
                }
            });
        });
    }
}