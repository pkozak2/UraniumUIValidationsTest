using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Mopups.Hosting;
using UraniumUI;

namespace UraniumUITestValidations
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseUraniumUI()
            .UseUraniumUIMaterial()
            .ConfigureMopups()
            .UseMauiCommunityToolkit()
            .ConfigureMopups()
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.ConfigureFonts(fonts =>
            {
                fonts.AddMaterialSymbolsFonts();
            });
            builder.Services.AddMopupsDialogs();
            builder.Services.AddTransient<MainPageViewModel>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
