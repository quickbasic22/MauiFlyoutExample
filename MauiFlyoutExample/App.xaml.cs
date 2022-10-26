using MauiFlyoutExample.Services;
using MauiFlyoutExample.Views;

namespace MauiFlyoutExample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        Routing.RegisterRoute(nameof(ItemsPage), typeof(ItemsPage));
        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
        Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));

        MainPage = new AppShell();
	}
}
