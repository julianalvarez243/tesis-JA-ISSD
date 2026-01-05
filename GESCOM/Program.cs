using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using GESCOM;
using capaEF; 
using System;
using System.Windows.Forms;
using capaPresentacion;

namespace GESCOM
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var services = new ServiceCollection();

            services.AddDbContext<GescomDBContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Default")));


            ServiceProvider = services.BuildServiceProvider();

            using (var context = ServiceProvider.GetRequiredService<GescomDBContext>())
            {
                context.Database.EnsureCreated(); 
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }

    public class GescomDBContext : DbContext
    {
        public GescomDBContext(DbContextOptions<GescomDBContext> options)
            : base(options)
        {
        }

    }
}
