using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Deepface_Recon.ApiBase.Model;

namespace Deepface_Recon.ApiBase;

public class APIEngine
{
    private static WebApplication APIApp;
    public static void ApiRun()
    {
        var args = Program.args;
        var builder = WebApplication.CreateBuilder(args);
            

        builder.WebHost.UseUrls("http://0.0.0.0:5000");

        builder.Services.AddScoped<ImgInModel, ImgInModel>();
        builder.Services.AddControllers();
        builder.Services.AddAuthentication
        (
            options =>
            {
                options.DefaultAuthenticateScheme = "JwtBearer";
                options.DefaultChallengeScheme = "JwtBearer";
            }
        ).AddJwtBearer
        (   "JwtBearer", options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Deepface-tests")),
                    ClockSkew = TimeSpan.FromMinutes(30),
                    ValidIssuer = "Deepface_tests",
                    ValidAudience = "Deepface_tests"
                };
            }
        );
        Task Token  = null;
        APIApp = builder.Build();

        APIApp.UseRouting();

        APIApp.UseAuthentication();

        APIApp.UseAuthorization();

        APIApp.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
        APIApp.Run();
    }

    public static void ApiStop()
    {
        APIApp.StopAsync();
    }

}