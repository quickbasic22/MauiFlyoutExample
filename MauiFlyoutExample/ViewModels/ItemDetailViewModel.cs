using MauiFlyoutExample.Data;
using MauiFlyoutExample.Models;
using System.Diagnostics;

namespace MauiFlyoutExample.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string description;
        private DateTime notedate;
        private bool done;
        //public Command<Item> UpdateCommand { get; set; }
        //public Command<Item> DeleteCommand { get; set; }

        public ItemDetailViewModel()
        {
            //UpdateCommand = new Command<Item>(UpdateItem);
            //DeleteCommand = new Command<Item>(DeleteItem);
        }

        //private async void DeleteItem(Item obj)
        //{
        //    var item = obj as Item;
        //    if (item != null)
        //    {
        //        await DataStore.DeleteItemAsync(item);
        //    }
        //    await Shell.Current.GoToAsync("..");
        //}

        //private async void UpdateItem(Item obj)
        //{
        //    var item = obj as Item;
        //    if (item != null)
        //    {
        //        await DataStore.UpdateItemAsync(item);
        //    }
        //    await Shell.Current.GoToAsync("..");
        //}

        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }
        public DateTime NoteDate
        {
            get => notedate;
            set => SetProperty(ref notedate, value);
        }
        public bool Done
        {
            get => done;
            set => SetProperty(ref done, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemByIdAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
                NoteDate = item.NoteDate;
                Done = item.Done;
                
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}