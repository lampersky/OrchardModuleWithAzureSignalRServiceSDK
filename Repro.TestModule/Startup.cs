using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using Repro.TestModule.Hubs;

namespace Repro.TestModule
{
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services
                .AddSignalR(options =>
                {
                    options.EnableDetailedErrors = true;
                })
                .AddAzureSignalR("Endpoint=https://your-endpoint.signalr.net;AccessKey={your-access-key};Version=1.0;");
        }

        public override void Configure(IApplicationBuilder builder, IEndpointRouteBuilder routes, IServiceProvider serviceProvider)
        {
            builder.UseEndpoints(config => {
                config.MapHub<TestHub>("/testHub", configureOptions: null);
            });
        }
    }
}