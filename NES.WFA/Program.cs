using NES_Core_CalorieCalculator.DAL.Context;
using NES_Core_CalorieCalculator.Service.Services;
using System;


namespace NES.WFA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDbContext context = new AppDbContext();
            ServiceAll serviceAll = new ServiceAll(context);
             
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration. 
            ApplicationConfiguration.Initialize();
            Application.Run(new FormHome(serviceAll));
        }
    }
}