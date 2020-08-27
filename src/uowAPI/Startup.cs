using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using uow.Entities;
using uow.Models;
using uowAPI.Services;

namespace uow
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            //dotnet user-secrets set "UserID" "TicketechAdmin"
            //dotnet user-secrets set "Password" "dieGo123!"

            //SqlConnectionStringBuilder builder =
            //new SqlConnectionStringBuilder();
            //builder.ConnectionString =
            //    Configuration.GetConnectionString("TicketechConnection");
            //builder.UserID = Configuration["UserID"];
            //builder.Password = Configuration["Password"];

            //services.AddDbContextPool<uowContext>(opt => 
            //    opt.UseSqlServer(Configuration.GetConnectionString(builder.ConnectionString)));                                    
            services.AddMvc();

            services.AddDbContextPool<uowContext>(opt =>
                opt.UseSqlServer(Configuration.GetConnectionString("TicketechConnection")));

            services.AddControllers().AddNewtonsoftJson();
            //services.AddControllers();

            // Add application services.
            services.AddTransient<ITransactionsRepository, TransactionsRepository>();
            services.AddTransient<IGaragesRepository, GaragesRepository>();
            services.AddTransient<ICustomersRepository, CustomersRepository>();
            services.AddTransient<IVehiclesRepository, VehiclesRepository>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
