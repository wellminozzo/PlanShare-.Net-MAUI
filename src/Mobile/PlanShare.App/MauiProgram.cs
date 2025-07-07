using PlanShare.App.Constants;

namespace PlanShare.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", FontFamily.MAIN_FONT_REGULAR);
                fonts.AddFont("OpenSans-Semibold.ttf", FontFamily.MAIN_FONT_BOLD);
            });

#if DEBUG
		
#endif

        return builder.Build();
    }
}
