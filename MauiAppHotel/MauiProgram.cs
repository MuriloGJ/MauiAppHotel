using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("BodoniModa-Italic.ttf", "BodoniModa-Italic");
                    fonts.AddFont("BodoniModa-VariableFont.ttf", "BodoniModa");
                    fonts.AddFont("Domine-Bold.ttf", "Domine-Bold");
                    fonts.AddFont("Domine-Medium.ttf", "Domine-Medium");
                    fonts.AddFont("Domine-Regular.ttf", "Domine-Regular");
                    fonts.AddFont("Domine-SemiBold.ttf", "Domine-SemiBold");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
