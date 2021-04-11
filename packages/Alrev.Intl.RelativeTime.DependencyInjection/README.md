# Alrev.Intl.RelativeTime.DependencyInjection

[![license](https://img.shields.io/github/license/pointnet/alrev-intl)](../../LICENSE)
[![nuget](https://img.shields.io/nuget/v/Alrev.Intl.RelativeTime.DependencyInjection)](https://www.nuget.org/packages/Alrev.Intl.RelativeTime.DependencyInjection/)
[![github](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/pointnet/8738e44902f9f103575dfa796d42fa73/raw/Alrev.Intl.RelativeTime.DependencyInjection.json)](https://github.com/pointnet/alrev-intl/packages/724135)

Plural Rules Dependency Injection library of [Alrev.Intel](../../../../)

## Installation

_.NET CLI_

```shell
> dotnet add package Alrev.Intl.RelativeTime.DependencyInjection
```

_Package Manager_

```shell
PM> Install-Package Alrev.Intl.RelativeTime.DependencyInjection
```

## Usage

```csharp
using Alrev.Intl.RelativeTime.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;

namespace Alrev.Intl.Samples.Mvc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLocalization();

            services.Configure<RequestLocalizationOptions>(options =>
            {
                CultureInfo[] supportedCultures = CultureInfo.GetCultures(CultureTypes.AllCultures);
                options.DefaultRequestCulture = new RequestCulture("en");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });

            services
                .AddControllersWithViews()
                .AddMvcLocalization();

            services.AddIntlRelativeTime();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseRequestLocalization();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
```
