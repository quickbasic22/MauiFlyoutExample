using MauiFlyoutExample.Models;
using MauiFlyoutExample.ViewModels;

namespace MauiFlyoutExample.Views;

public partial class NewItemPage : ContentPage
{
	public Item Item { get; set; }
	public NewItemPage()
	{
		InitializeComponent();
        BindingContext = new NewItemViewModel();
    }
}