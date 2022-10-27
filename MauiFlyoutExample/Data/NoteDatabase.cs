using MauiFlyoutExample.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiFlyoutExample.Data
{
    public class NoteDatabase
    {
        readonly SQLiteAsyncConnection database;
        public NoteDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Item>().Wait();
        }
       
        public Task<List<Item>> GetItemsAsync()
        {
            return database.Table<Item>().ToListAsync();
        }
        public Task<Item> GetItemByIdAsync(string id)
        {
            return database.Table<Item>().FirstOrDefaultAsync(x => x.Id == id);
        }
        public Task<int> SaveItemAsync(Item item)
        {
            if (item.Id != null)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }
        public Task<int> DeleteItemAsync(Item item)
        {
            return database.DeleteAsync(item);
        }
    }
}
