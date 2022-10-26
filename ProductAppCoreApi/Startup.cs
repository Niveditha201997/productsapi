using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ProductBussiness.Services;
using Microsoft.OpenApi.Models;
using ProductData.Data;
using ProductData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAppCoreApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            string connectionStr = Configuration.GetConnectionString("sqlconnection");
            services.AddDbContext<ProductDbContext>(options => options.UseSqlServer(connectionStr));
            services.AddControllers();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ProductServices, ProductServices>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<ArticleServices, ArticleServices>();
            services.AddTransient<IColourRepository, ColorRepository>();
            services.AddTransient<ColourServices, ColourServices>();
            services.AddTransient<ISizeRepository, SizeRepository>();
            services.AddTransient<SizeServices, SizeServices>();
            services.AddSwaggerGen();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Product API",
                    Description = "Product Management Sytem API",
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API"));

            app.UseHttpsRedirection();  

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
