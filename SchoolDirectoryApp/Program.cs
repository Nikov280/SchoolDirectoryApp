using Microsoft.AspNetCore.Components.Web;
using SchoolDirectoryApp;
using SchoolDirectoryApp.Services;
using SchoolDirectoryApp.Components;

namespace SchoolDirectoryApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // ==========================================
            // ADDED CODE FOR THE SCHOOL DIRECTORY APP
            // ==========================================

            // Register a basic HttpClient to make requests to the external API
            builder.Services.AddScoped(sp => new HttpClient());

            // Register SchoolService for Dependency Injection so it can be used in Razor pages
            builder.Services.AddScoped<SchoolService>();

            builder.Services.AddScoped<AppStateService>();

            // ==========================================

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}