using Porto.UI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

Console.WriteLine("Hello World!");

var host = new WebHostBuilder()
.UseKestrel()
.UseContentRoot(Directory.GetCurrentDirectory())
.UseStartup<Startup>()
.Build();

host.Run();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
