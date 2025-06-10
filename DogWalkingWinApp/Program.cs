using DogWalkingWinApp.Data;
using DogWalkingWinApp.Repositories;
using DogWalkingWinApp.ViewModel;
using DogWalkingWinApp.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DogWalkingWinApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            services.AddDbContext<DogWalkingDbContext>(options =>
                options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=DogWalkDB;Trusted_Connection=True;"));

            services.AddSingleton<IDogWalkView, CtrlDogWalk>();
            services.AddSingleton<IDogWalkListView, CtrlDogWalkList>();
            services.AddSingleton<IDogWalkController, DogWalkController>();
            services.AddSingleton<IDogWalkRepository, DogWalkRepository>();
            services.AddScoped<FormDogWalks>();

            using var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var mainForm = serviceProvider.GetRequiredService<FormDogWalks>();
            Application.Run(mainForm);
        }
    }
}