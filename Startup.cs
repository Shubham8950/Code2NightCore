using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Code2Night.DAL.Common;
using Code2Night.DAL.Interfaces;
using Code2Night.DAL.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Net.Http.Headers;
using Newtonsoft.Json;

namespace Code2Night
{
    public class Startup
    {
        public IConfigurationRoot Configuration
        {
            get;

            set;
        }

        public static string ConnectionString
        {
            get;

            private set;
        }
        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder().SetBasePath(CurrentDirectoryHelpers.GetServerPath()).AddJsonFile("appSettings.json").Build();

            //  Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });

            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
           // services.AddMvc().AddRazorOptions(options => options.AllowRecompilingViewsOnFileChange = true);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient<IBlog, BlogRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IFeedback, FeedbackRepo>();
            services.AddScoped<ISitemapGenerator, SitemapGenerator>();
            services.AddSingleton<IConfiguration>(Configuration);
            //services.Configure<IISServerOptions>(options =>
            //{
            //    options.AutomaticAuthentication = false;

            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
                if (env.IsDevelopment())
                {
                    app.UseExceptionHandler(a => a.Run(async context =>
                    {
                        var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                        var exception = exceptionHandlerPathFeature.Error;
                        if (!Directory.Exists(env.ContentRootPath + "\\App_Data\\log\\"))
                        {
                            Directory.CreateDirectory(env.ContentRootPath + "\\App_Data\\log\\");
                        }
                        var filename = env.ContentRootPath + "\\App_Data\\" + "log\\" + "Logerror.txt";
                        var sw = new System.IO.StreamWriter(filename, true);
                        sw.WriteLine(DateTime.Now.ToString() + " " + exception.Message + " " + exception.InnerException + " " + exception.StackTrace + " " + exception.Source);
                        sw.Close();
                        var result = JsonConvert.SerializeObject(new { error = exception.Message });
                        context.Response.ContentType = "application/json";
                        await context.Response.WriteAsync(result);
                    }));
                }
                else
                {
                    app.UseExceptionHandler(a => a.Run(async context =>
                    {
                        var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                        var exception = exceptionHandlerPathFeature.Error;
                        if (!Directory.Exists(env.ContentRootPath + "\\App_Data\\log\\"))
                        {
                            Directory.CreateDirectory(env.ContentRootPath + "\\App_Data\\log\\");
                        }
                        var filename = env.ContentRootPath + "\\App_Data\\" + "log\\" + "Logerror.txt";
                        var sw = new System.IO.StreamWriter(filename, true);
                        sw.WriteLine(DateTime.Now.ToString() + " " + exception.Message + " " + exception.InnerException + " " + exception.StackTrace + " " + exception.Source);
                        sw.Close();
                        var result = JsonConvert.SerializeObject(new { error = exception.Message });
                        context.Response.ContentType = "application/json";
                        await context.Response.WriteAsync(result);
                    }));
                    // app.UseExceptionHandler("/Home/Error");
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }
               // app.UseWebOptimizer();
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                app.UseRequestLocalization();
                app.UseSession();
                app.UseHttpsRedirection();
                app.UseStaticFiles();
                if (!Directory.Exists(Path.Combine(CurrentDirectoryHelpers.GetServerPath(), "Uploads")))
                    Directory.CreateDirectory(Path.Combine(CurrentDirectoryHelpers.GetServerPath(), "Uploads"));
                app.UseStaticFiles(new StaticFileOptions
                {
                    FileProvider = new PhysicalFileProvider(Path.Combine(CurrentDirectoryHelpers.GetServerPath(), "Uploads")),
                    RequestPath = "/Uploads",
                    OnPrepareResponse = ctx =>
                    {
                        const int durationInSeconds = 60 * 60 * 24*365;
                        ctx.Context.Response.Headers[HeaderNames.CacheControl] =
                            "public,max-age=" + durationInSeconds;
                    }
                });
           
            app.UseCookiePolicy();
                ConnectionString = Configuration["ConnectionStrings:ConnectionString"];
                app.UseMvc(routes =>
                {
                    routes.MapRoute(
                        name: "default",
                        template: "{controller=Blog}/{action=index}/{id?}");
                });
           
        }
    }
}
