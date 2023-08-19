using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace Porto.API
{
    public class Startup
    {
        private readonly IConfiguration _config;
        [Obsolete]
        public Startup(IConfiguration config, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            _config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHealthChecks();

            #region Swagger Configuration
            services.AddSwaggerGen(c => {
                #region Bearer Token icin Swagger'a buton eklenmesi
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Token yazarken 'Bearer TokenKey' formatında yazmanız gerekmektedir"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference =new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[]{}
                    }
                });
                #endregion
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Porto API", Version = "v1" });
            });
            #endregion

            #region Token Configuration
            services.AddCors();
            var appSettingSection = _config.GetSection("Token:SecretKey");
            services.Configure<string>(appSettingSection);
            var TokenSecretKeyString = appSettingSection.Get<string>();
            var key = Encoding.ASCII.GetBytes(TokenSecretKeyString ?? string.Empty);
            services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x => {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
                x.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = context => {
                        if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                            context.Response.Headers.Add("Token-Expired", "true");
                        return Task.CompletedTask;
                    }
                };
            });
            #endregion

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region Swagger Configuration
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
            });
            #endregion

            #region Token Configuration
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
            app.UseAuthentication();
            #endregion

            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endPoints => {
                endPoints.MapControllers();
            });
        }
    }
}
