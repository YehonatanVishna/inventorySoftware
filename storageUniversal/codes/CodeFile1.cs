using SQLite;
using MauiApp3;

namespace TodoSQLite.Data;

public class InventoryRowDatabase
{
    SQLiteAsyncConnection Database;
    public InventoryRowDatabase()
    {
    }
    async Task Init()
    {
        if (Database is not null)
            return;

        Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        var result = await Database.CreateTableAsync<InventoryRow>();
    }

    public async Task<List<InventoryRow>> GetItemsAsync()
    {
        await Init();
        SQLite.SQLiteConnection a = new SQLiteConnection(Constants.DatabasePath, Constants.Flags);
        //return a.Table<InventoryRow>().ToList();
        return await Database.Table<InventoryRow>().ToListAsync();
    }

    //public async Task<List<InventoryRow>> GetItemsNotDoneAsync()
    //{
    //    await Init();
    //    return await Database.Table<InventoryRow>().Where(t => t.Done).ToListAsync();

    //    // SQL queries are also possible
    //    //return await Database.QueryAsync<InventoryRow>("SELECT * FROM [InventoryRow] WHERE [Done] = 0");
    //}

    public async Task<InventoryRow> GetItemAsync(int id)
    {
        await Init();
        return await Database.Table<InventoryRow>().Where(i => i.ID == id).FirstOrDefaultAsync();
    }

    public async Task<int> SaveItemAsync(InventoryRow item)
    {
        await Init();
        if (item.ID != 0)
        {
            return await Database.UpdateAsync(item);
        }
        else
        {
            return await Database.InsertAsync(item);
        }
    }

    public async Task<int> DeleteItemAsync(InventoryRow item)
    {
        await Init();
        return await Database.DeleteAsync(item);
    }
}