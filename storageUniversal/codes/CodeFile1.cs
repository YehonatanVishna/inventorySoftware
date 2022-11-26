using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace storageUniversal
{

    public class UsersDatabase
    {
        SqliteConnection Database;
        public UsersDatabase()
        {
        }
        async Task Init()
        {
            if (Database != null)
                return;

            Database = new SqliteConnection($"Filename={Constants.DatabasePath}");
            Database.Open();
            String tableCommand = "CREATE TABLE IF NOT " +
        "EXISTS Users ( [ID][int] IDENTITY NOT NULL," +
        "[FName] [nchar] (20) NULL," +
        "[LName] [nchar] (20) NULL," +
        "[BDate] [datetime] NULL," +
        "[compeny] [nchar] (20) NULL," +
        "[email] [nchar] (30) NULL," +
        "[password] [nchar] (20) NULL)";
            SqliteCommand createTable = new SqliteCommand(tableCommand, Database);
            createTable.ExecuteReader();
            //Database.Close();
        }

        public async Task<List<User>> GetItemsAsync()
        {
            await Init();
            Database.Open();
            var qury = "select * from Users";
            var comd = new Microsoft.Data.Sqlite.SqliteCommand(qury, Database);
            var reader = comd.ExecuteReader();
            var tbl = new DataTable();
            tbl.Load(reader);
            var users = new List<User>();
            foreach(DataRow dr in tbl.Rows)
            {
                var user = new User();
                user.ID = int.Parse(dr["ID"].ToString());
                user.Password = dr["password"].ToString();
                user.Email = dr["email"].ToString();
                user.Fname = dr["FName"].ToString();
                user.Lname = dr["LName"].ToString();
                user.Compeny = dr["compeny"].ToString();
                users.Add(user);
            }
            return users;
        }

        //public async Task<List<InventoryRow>> GetItemsNotDoneAsync()
        //{
        //    await Init();
        //    return await Database.Table<InventoryRow>().Where(t => t.Done).ToListAsync();

        //    // SQL queries are also possible
        //    //return await Database.QueryAsync<InventoryRow>("SELECT * FROM [InventoryRow] WHERE [Done] = 0");
        //}

        //public async Task<InventoryRow> GetItemAsync(int id)
        //{
        //    await Init();
        //    return await Database.Table<InventoryRow>().Where(i => i.ID == id).FirstOrDefaultAsync();
        //}
        public async Task<bool> InsertItemAsync(User item)
        {
            await Init();
            string nonQury = "Insert into Users (ID, email, password, FName, LName, BDate, compeny) values (" + item.ID.ToString() + ",'" + item.Email + "', '" + item.Password + "','" + item.Fname.ToString() + "', '" + item.Lname + "', " + "CAST('" + item.BDate.ToShortDateString() + "' AS DateTime)" + ", '" + item.Compeny + "');";
            var comd = new SqliteCommand(nonQury, Database);
            var a = comd.ExecuteNonQuery();
            comd.Dispose();
            return a > 0;

        }
        public bool DeleteAll()
        {
            string nonQury = "Delete from Users";
            var comd = new SqliteCommand(nonQury, Database);
            var a = comd.ExecuteNonQuery();
            comd.Dispose();
            return a > 0;

        }
        //public async Task<bool> InsertItemAsync(User item)
        //{
        //    await Init();
        //    string nonQury = "Insert into Users (ID, email, password) values (" + item.ID.ToString() + ", '" + item.Email + "', '" + item.Password + "');";
        //    var comd = new SqliteCommand(nonQury, Database);
        //    var a = comd.ExecuteNonQuery();
        //    comd.Dispose();
        //    //Database.Close();
        //    return a > 0;

        //}

        //public async Task<int> DeleteItemAsync(InventoryRow item)
        //{
        //    await Init();
        //    return await Database.DeleteAsync(item);
        //}
    }
}