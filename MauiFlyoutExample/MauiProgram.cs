using MauiFlyoutExample.Models;
using MauiFlyoutExample.Services;
using MauiFlyoutExample.ViewModels;
using MauiFlyoutExample.Views;
using Microsoft.Extensions.DependencyInjection;
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

		   builder.Services.AddSingleton<IDataStore<Item>, MockDataStore>();
		   
		   builder.Services.AddSingleton<BaseViewModel>();
		   // builder.Services.AddSingleton<LoginViewModel>();
		   builder.Services.AddSingleton<NewItemViewModel>();
		   builder.Services.AddSingleton<ItemsViewModel>();
		   builder.Services.AddSingleton<ItemDetailViewModel>();

		    builder.Services.AddSingleton<AboutPage>();
			builder.Services.AddSingleton<ItemDetailPage>();
			builder.Services.AddSingleton<ItemsPage>();
			builder.Services.AddSingleton<NewItemPage>();





#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
