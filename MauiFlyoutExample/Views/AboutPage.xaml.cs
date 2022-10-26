using MauiFlyoutExample.Services;
using MauiFlyoutExample.ViewModels;

namespace MauiFlyoutExample.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
		BindingContext = Helpers.ServiceHelper.GetService<AboutViewModel>();
	}
}