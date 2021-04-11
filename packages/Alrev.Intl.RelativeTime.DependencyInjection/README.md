# Alrev.Intl.RelativeTime.DependencyInjection

[![license](https://img.shields.io/github/license/pointnet/alrev-intl)](../../LICENSE)
[![nuget](https://img.shields.io/nuget/v/Alrev.Intl.RelativeTime.DependencyInjection)](https://www.nuget.org/packages/Alrev.Intl.RelativeTime.DependencyInjection/)
[![github](https://img.shields.io/endpoint?url=https://gist.githubusercontent.com/pointnet/8738e44902f9f103575dfa796d42fa73/raw/Alrev.Intl.RelativeTime.DependencyInjection.json)](https://github.com/pointnet/alrev-intl/packages/724135)

Plural Rules Dependency Injection library of [Alrev.Intel](../../../../)

## Installation

**.NET CLI**

```shell
> dotnet add package Alrev.Intl.RelativeTime.DependencyInjection
```

**Package Manager**

```shell
PM> Install-Package Alrev.Intl.RelativeTime.DependencyInjection
```

## Usage

**~/Views/_ViewImports.cshtml**

```html
@*<added>*@
@using Alrev.Intl.Abstractions.RelativeTime
@*</added>*@

@using Alrev.Intl.Samples.Mvc
@using Alrev.Intl.Samples.Mvc.Models
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```

**~/Views/Home/Index.cshtml**

```html
@*<added>*@
@inject IRelativeTimeFormatter RelativeTimeFormatter
@*</added>*@

@{
    ViewData["Title"] = "Home Page";
}

<div class="container">
    <div class="row">
      @RelativeTimeFormatter.Format(0)
    </div>
    <div class="row">
      @RelativeTimeFormatter.Format(0, RelativeTimeUnitValues.Day)
    </div>
    <div class="row">
      @RelativeTimeFormatter.Format(0, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Narrow)
    </div>
    <div class="row">
      @RelativeTimeFormatter.Format(0, RelativeTimeUnitValues.Day, RelativeTimeStyleValues.Narrow, RelativeTimeNumericValues.Auto)
    </div>
</div>
```

**Startup.cs**

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

            // <added>
            services.AddIntlRelativeTime();
            // </added>

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