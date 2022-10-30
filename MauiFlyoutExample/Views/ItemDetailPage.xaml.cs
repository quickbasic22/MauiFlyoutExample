using MauiFlyoutExample.Models;
using MauiFlyoutExample.ViewModels;
using System.Runtime.CompilerServices;

namespace MauiFlyoutExample.Views;

public partial class ItemDetailPage : ContentPage
{
	ItemDetailViewModel _viewModel;
    public ItemDetailPage()
	{
		InitializeComponent();
		BindingContext = _viewModel = new ItemDetailViewModel();
		// BindingContext = Helpers.ServiceHelper.GetService<ItemDetailViewModel>();
    }

	private async void UpdateButton_Clicked(object sender, EventArgs e)
	{
		var item = sender as Item;
		if (item != null)
		{
		   await _viewModel.DataStore.UpdateItemAsync(item);
		}
		await Shell.Current.GoToAsync("..");
    }

	private async void DeleteButton_Clicked(object sender, EventArgs e)
	{
        var item = sender as Item;
        if (item != null)
        {
            await _viewModel.DataStore.DeleteItemAsync(item);
        }
		await Shell.Current.GoToAsync("..");
    }
}