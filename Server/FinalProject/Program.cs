using BL;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<BLManager>();

builder.Services.AddControllers();

var provider = builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });

});
    var app = builder.Build();

    app.UseHttpsRedirection();
    app.UseCors();
    app.MapControllers();
    app.MapGet("/", () => "Hello World!");
    app.Run();
