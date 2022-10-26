using MauiFlyoutExample.Models;
using MauiFlyoutExample.Services;
using MauiFlyoutExample.ViewModels;
namespace MauiFlyoutExample.Views;

public partial class NewItemPage : ContentPage
{
	public Item Item { get; set; }
    
    public NewItemPage()
	{
		InitializeComponent();
        BindingContext = Helpers.ServiceHelper.GetService<NewItemViewModel>();
    }
}