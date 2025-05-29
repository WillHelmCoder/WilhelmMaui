using Microsoft.Extensions.Logging;
using w002.ShellFactory.ShellCompositions;
using w002.ShellFactory.Views;



namespace w002.ShellFactory
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<AdminShell>();
            builder.Services.AddTransient<FreeShell>();
            builder.Services.AddTransient<OpenShell>();
            builder.Services.AddTransient<PremiumShell>();

            builder.Services.AddTransient<PremiumPage>();
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<FreePage>();
            builder.Services.AddTransient<AdminPage>();
            builder.Services.AddTransient<ListPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
