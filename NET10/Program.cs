using BlazorApp.Components;
using Syncfusion.Blazor;
using Syncfusion.Licensing;
using ElectronNET.API;
using ElectronNET.API.Entities;
var builder = WebApplication.CreateBuilder(args);

// Syncfusion licensing
SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddSyncfusionBlazor();

// Electron services
builder.Services.AddElectron();

// Electron window bootstrap (modern ElectronNET.Core)
builder.UseElectron(args, async () =>
{
    var options = new BrowserWindowOptions
    {
        Width = 1200,
        Height = 800,
        Show = false,
        AutoHideMenuBar = true,
        // IsRunningBlazor = true,   // Optional: enable if Blazor script loading issues occur.
    };

    var window = await Electron.WindowManager.CreateWindowAsync(options);

    window.OnReadyToShow += () => window.Show();
    window.OnClosed += () => Electron.App.Quit();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles(); // Required for serving assets like _content/ (Syncfusion).
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
// app.UseHttpsRedirection(); <-- Do NOT enable for Electron app

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<BlazorApp.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();
