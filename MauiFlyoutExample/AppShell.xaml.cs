using MauiFlyoutExample.Views;

namespace MauiFlyoutExample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
        Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        Routing.RegisterRoute(nameof(ItemsPage), typeof(ItemsPage));
        Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
    }

    private async void OnMenuItemClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//LoginPage");
    }
}
