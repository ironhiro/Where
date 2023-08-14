using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace WhereIsIt;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("MBC 1961 M.ttf", "MBCFont");
				fonts.AddFont("Brands-Regular-400.otf", "BrandsRegular");
                fonts.AddFont("Free-Regular-400.otf", "FreeRegular");
                fonts.AddFont("Free-Solid-900.otf", "FreeSolid");
            })
			.UseMauiMaps();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
