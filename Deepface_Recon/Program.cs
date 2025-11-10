using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

using Deepface_Recon.ApiBase.Model;
using Microsoft.Extensions.Hosting;

namespace Deepface_Recon
{
    static class Program
    {
        
        public static int Wlcmflag = 0;
        [STAThread]
        public static void Main(string[] args)
        {
            Program.args = args;
            if (Wlcmflag == 0)
            {
                Application.Run(new Welcome_Screen());
            }

            if (Wlcmflag == 1)
            {
                PageSwitch(2);
            }
        }

        private static string[] args;
      

        public static void PageSwitch(int LoadKey)
        {
            switch (LoadKey)
            {
                case 1:
                    var Thread1 = new Thread(LoadWelcome);
                    Thread1.Start();
                return;
                
                case 2:
                    Application.ExitThread();
                    var Thread2 = new Thread(LoadMain);
                    Thread2.Start();
                return;
                
                case 3:
                    var Thread3 = new Thread(LoadSetup);
                    Thread3.Start();
                    return;
                case 4:
                    Application.ExitThread();
                    var Thread4 = new Thread(LoadAskUser);
                    Thread4.Start();
                    return;
                case 5:
                    var Thread5 = new Thread(ApiRun);
                    Thread5.Start();
                    return;
            }
        }

        public static void ApiRun()
        {
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

            var app = builder.Build();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

                app.Run();

        }

        private static void LoadWelcome()
        {
            Application.Exit(); 
            Application.Run(new Welcome_Screen());
            
            
        }
     

        private static void LoadSetup()
        {
            Application.Run(new Setup_Download());
        }

        private static void LoadAskUser()
        {
            Application.Run(new AskUser());
        }

        private static void LoadMain()
        {
            Application.ExitThread();
            Application.Run(new MainMenu());
        }

    }
}