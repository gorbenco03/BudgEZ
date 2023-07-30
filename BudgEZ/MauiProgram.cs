using BudgEZ.ViewModels;
using BudgEZ.Views;
using Microsoft.Extensions.Logging;

namespace BudgEZ;

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

		builder.Services.AddSingleton<HomePage>();
		builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<LoginPageViewModel>();
		builder.Services.AddSingleton<SettingsPage>();
        builder.Services.AddSingleton<ToolsPage>();

        return builder.Build();
	}
}
