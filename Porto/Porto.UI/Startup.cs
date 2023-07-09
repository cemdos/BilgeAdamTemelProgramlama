namespace Porto.UI
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddMvc(option => option.EnableEndpointRouting = false);
		}

		public void Configure(IApplicationBuilder app)
		{
			_ = app.UseMvc();

			app.Run(context => {
				return context.Response.WriteAsync("Mvc uygulamam ayaga kalktı");
			});

		}
	}
}
