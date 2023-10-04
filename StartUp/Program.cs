using Application;
using Database;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.AddDatabaseServices(configuration);

builder.Services.AddApplicationServices();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();