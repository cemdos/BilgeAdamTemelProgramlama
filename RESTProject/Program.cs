using Microsoft.OpenApi.Models;
using RESTProject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c => {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v2" });
});


var app = builder.Build();

// Configure the HTTP request pipeline.

#if DEBUG
    app.UseSwagger();
    app.UseSwaggerUI(c => {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
    });
#endif

app.UseAuthorization();

app.MapControllers();

app.Run();
