using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.JSInterop;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

var host = builder.Build();

var jsRuntime = host.Services.GetRequiredService<IJSRuntime>();
var cultureName = await jsRuntime.InvokeAsync<string>("blazorCulture.get");

if (!string.IsNullOrEmpty(cultureName))
{
    var culture = new CultureInfo(cultureName);
    CultureInfo.DefaultThreadCurrentCulture = culture;
    CultureInfo.DefaultThreadCurrentUICulture = culture;
}

await host.RunAsync();
