using BlazorPractice.Client.States;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// DI ƒRƒ“ƒeƒi‚É AppState(‹¤—Lstate) ‚ð“o˜^
builder.Services.AddSingleton<AppState>();

await builder.Build().RunAsync();
