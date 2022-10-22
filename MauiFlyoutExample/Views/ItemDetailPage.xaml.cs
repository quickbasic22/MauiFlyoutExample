using MauiFlyoutExample.ViewModels;

namespace MauiFlyoutExample.Views;

public partial class ItemDetailPage : ContentPage
{
	public ItemDetailPage()
	{
		InitializeComponent();
        BindingContext = new ItemDetailViewModel();
    }
}