using BlazorPractice.Client.States;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// DI コンテナに AppState(共有state) を登録
builder.Services.AddSingleton<AppState>();

await builder.Build().RunAsync();
