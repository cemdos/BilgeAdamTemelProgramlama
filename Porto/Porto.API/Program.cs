
using Porto.API;

var hostBuilder = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder => {
        webBuilder.UseStartup<Startup>();
    });

var builder = hostBuilder.Build();
builder.Run();
