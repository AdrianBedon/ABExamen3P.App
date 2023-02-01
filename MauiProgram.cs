using ABExamen3P.ABData;

namespace ABExamen3P;

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

		string dbPath = ABFileAccessHelper.GetLocalFilePath("ABpokemon.db3");
		builder.Services.AddSingleton<ABDatabase>(s => ActivatorUtilities.CreateInstance<ABDatabase>(s, dbPath));

		return builder.Build();
	}
}
