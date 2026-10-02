using Microsoft.Extensions.Logging;
using ViagemOnboardingPage.ViewModels;
using ViagemOnboardingPage.Views;

namespace ViagemOnboardingPage
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<ViagemItemViewModel>();
            builder.Services.AddTransient<ViagemPage>();

            return builder.Build();
        }
    }
}
