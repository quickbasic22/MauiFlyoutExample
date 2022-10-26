using MauiFlyoutExample.Models;
using MauiFlyoutExample.Services;
using MauiFlyoutExample.ViewModels;

namespace MauiFlyoutExample.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ItemsPage : ContentPage
{
    ItemsViewModel _viewModel;
    private IDataStore<Item> data;

    public ItemsPage()
    {
        InitializeComponent();
        BindingContext = _viewModel = Helpers.ServiceHelper.GetService<ItemsViewModel>();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.OnAppearing();
    }
}