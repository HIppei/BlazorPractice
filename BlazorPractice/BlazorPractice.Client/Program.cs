using BlazorPractice.Client.States;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// DI �R���e�i�� AppState(���Lstate) ��o�^
builder.Services.AddSingleton<AppState>();

await builder.Build().RunAsync();
