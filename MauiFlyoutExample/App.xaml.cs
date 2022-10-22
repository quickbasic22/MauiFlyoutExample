using MauiFlyoutExample.Services;

namespace MauiFlyoutExample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		DependencyService.Register<MockDataStore>();
		MainPage = new AppShell();
	}
}
