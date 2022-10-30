using MauiFlyoutExample.ViewModels;

namespace MauiFlyoutExample.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
		BindingContext = new AboutViewModel();
		// BindingContext = Helpers.ServiceHelper.GetService<AboutViewModel>();
	}
}