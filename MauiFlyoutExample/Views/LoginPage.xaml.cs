using MauiFlyoutExample.ViewModels;

namespace MauiFlyoutExample.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class LoginPage : ContentPage
{ 
    public LoginPage()
	{
		InitializeComponent();
        this.BindingContext = Helpers.ServiceHelper.GetService<LoginViewModel>();
    }
}