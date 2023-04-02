using ei8.Cortex.Gps.Mapper.ViewModels;
using ei8.Cortex.Gps.Mapper.Views;
using Microsoft.Extensions.Logging;

namespace ei8.Cortex.Gps.Mapper;

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
			})
			.UseMauiMaps();

        builder.Services.AddSingleton<IGeolocation>(Geolocation.Default);
        builder.Services.AddSingleton<IGeocoding>(Geocoding.Default);

        builder.Services.AddTransient<MapViewModel>();
        builder.Services.AddTransient<MapView>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
