using MauiFlyoutExample.Models;
using SQLite;

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
        
        public async Task<List<Item>> GetItemsAsync()
        {
            return await database.Table<Item>().ToListAsync();
        }
        public async Task<Item> GetItemByIdAsync(string id)
        {
            return await database.Table<Item>().FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<int> AddItemAsync(Item item)
        { 
             return await database.InsertAsync(item);
        }
        public async Task<int> UpdateItemAsync(Item item)
        {
            return await database.UpdateAsync(item);
        }
        public async Task<int> DeleteItemAsync(Item item)
        {
            return await database.DeleteAsync(item);
        }
    }
}
