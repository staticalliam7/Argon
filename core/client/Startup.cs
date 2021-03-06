using Coravel;
using GrpcService.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Argon.Sceduler;

namespace Main
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public static void ConfigureServices(IServiceCollection services)
        {

            services.AddScheduler();
            services.AddTransient<BlockJob>();

            services.AddGrpc();
            services.AddCors(o => o.AddPolicy("AllowAll", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader()
                       .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
            }));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
           // app.UseGrpcWeb(new GrpcWebOptions { DefaultEnabled = true });
            //app.UseCors();
            //app.UseGrpcWeb(); // Must be added between UseRouting and UseEndpoints
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<BlockchainService>();
                //endpoints.MapGrpcService<BlockchainService>().EnableGrpcWeb().RequireCors("AllowAll");
                //endpoints.MapGrpcService<BlockchainService>().RequireCors("AllowAll"); ;

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync(
                        "Communication with gRPC endpoints" +
                        " must be made through a gRPC client.");
                });
            });
        }
    }
}