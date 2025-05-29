using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace w003.T1.Login_shells_appsettings
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
