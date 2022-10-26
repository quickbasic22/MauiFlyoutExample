using MauiFlyoutExample.Models;
using MauiFlyoutExample.Services;
using MauiFlyoutExample.ViewModels;
using System.Runtime.CompilerServices;

namespace MauiFlyoutExample.Views;

public partial class ItemDetailPage : ContentPage
{
	private IDataStore<Item> data;
	
	public ItemDetailPage()
	{
		InitializeComponent();
        BindingContext = Helpers.ServiceHelper.GetService<ItemDetailViewModel>();
    }
}