using MauiFlyoutExample.Models;
using MauiFlyoutExample.ViewModels;
using System.ComponentModel;

namespace MauiFlyoutExample.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ItemsPage : ContentPage
{
    ItemsViewModel _viewModel;
    
    public ItemsPage()
    {
        InitializeComponent();
        BindingContext = _viewModel = new ItemsViewModel();
        // BindingContext = _viewModel = Helpers.ServiceHelper.GetService<ItemsViewModel>();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewModel.OnAppearing();
    }

    private void swipeitem_Clicked(object sender, EventArgs e)
    {
        var swipeitem = sender as SwipeItem;
        var item = swipeitem.BindingContext as Item;
        //if (item != null)
        //{
        //    _viewModel.Items.Remove(item);
        //}

        _viewModel.DeleteCommand.Execute(item);
    }
}