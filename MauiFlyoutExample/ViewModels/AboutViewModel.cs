using System.Windows.Input;

namespace MauiFlyoutExample.ViewModels
{
    public class AboutViewModel
    {
        public ICommand OpenWebCommand { get; }
        public AboutViewModel()
        {
           // Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }   
    }
}
