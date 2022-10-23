﻿using MauiFlyoutExample.Services;
using Microsoft.Extensions.Logging;

namespace MauiFlyoutExample;

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
		DependencyService.Register<MockDataStore>();
		// builder.Services.AddSingleton<MockDataStore>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
