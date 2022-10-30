using MauiFlyoutExample.Data;
using MauiFlyoutExample.Views;
using System.Diagnostics;

namespace MauiFlyoutExample;

public partial class App : Application
{
	static NoteDatabase database;
	public App()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
		Debug.WriteLine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Item.db"));
		Debug.Assert(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Item.db") != null);
		MainPage = new AppShell();
	}

	public static NoteDatabase Database
	{
		get
		{
             if (database == null)
			{
				database = new NoteDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Item.db"));
			}
			 return database;
		}
	}
}
