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
        //מוודא שמסד הנתונים מאותחל אם לא מאתחל אותו
        //makes shure the db is initilized
        async Task Init()
        {
            // Return if the database has already been initialized
            if (Database != null)
                return;

            // Create a new Sqlite database connection using the specified database file path
            Database = new SqliteConnection($"Filename={Constants.DatabasePath}");

            // Open the database connection
            Database.Open();

            // Create the table command string with the specified columns and data types
            //שאילתה שיוצרת את מסד הנתונים אם הוא לא כבר קיים
            String tableCommand = "CREATE TABLE IF NOT " +
        "EXISTS Users ( [ID][int] IDENTITY NOT NULL," +
        "[FName] [nchar] (20) NULL," +
        "[LName] [nchar] (20) NULL," +
        "[BDate] [datetime] NULL," +
        "[compeny] [nchar] (20) NULL," +
        "[email] [nchar] (30) NULL," +
        "[password] [nchar] (20) NULL)";

            // Create a new Sqlite command using the table command string and the database connection
            SqliteCommand createTable = new SqliteCommand(tableCommand, Database);

            // Execute the command to create the table
            createTable.ExecuteReader();
        }

        //מחזיר רשימה של כל המשתמשים במסד הנתונים המקומי
        //returns a User list of all users in db
        public async Task<List<User>> GetItemsAsync()
        {
            // Initialize the database
            await Init();

            // Create a query string to select all rows from the Users table
            var qury = "select * from Users";

            // Create a new Sqlite command using the query string and the database connection
            var comd = new Microsoft.Data.Sqlite.SqliteCommand(qury, Database);

            // Execute the command to retrieve the rows from the table
            var reader = comd.ExecuteReader();

            // Create a new DataTable to hold the rows
            var tbl = new DataTable();

            // Load the rows into the DataTable
            tbl.Load(reader);

            // Create a list to hold the user objects
            var users = new List<User>();

            // Loop through each row in the DataTable
            foreach (DataRow dr in tbl.Rows)
            {
                // Create a new User object and populate its properties with the data from the DataRow
                var user = new User();
                user.ID = int.Parse(dr["ID"].ToString());
                user.Password = dr["password"].ToString();
                user.Email = dr["email"].ToString();
                user.Fname = dr["FName"].ToString();
                user.Lname = dr["LName"].ToString();
                user.Compeny = dr["compeny"].ToString();

                // Add the user to the list of users
                users.Add(user);
            }

            // Return the list of users
            return users;
        }
        //מקבל עצם של משתמש ומכניס את המידע המוכל בעצם למסד הנתונים
        //takes a user object and inserts it into the db
        public async Task<bool> InsertItemAsync(User item)
        {
            // Initialize the database
            await Init();

            // Create a string containing the query to insert a new row into the Users table with the data from the provided User object
            string nonQury = "Insert into Users (ID, email, password, FName, LName, BDate, compeny) values (" + item.ID.ToString() + ",'" + item.Email + "', '" + item.Password + "','" + item.Fname.ToString() + "', '" + item.Lname + "', " + "CAST('" + item.BDate.ToShortDateString() + "' AS DateTime)" + ", '" + item.Compeny + "');";

            // Create a new Sqlite command using the query string and the database connection
            var comd = new SqliteCommand(nonQury, Database);

            // Execute the command to insert the new row
            var a = comd.ExecuteNonQuery();

            // Dispose of the command object
            comd.Dispose();

            // Return a value indicating whether the insertion was successful
            return a > 0;
        }
        //מוחק את כל המשתמשים במסד הנתונים
        //deletes all users in db
        public async Task<bool> DeleteAll()
        {
            // Initialize the database
            await Init();

            // Create a string containing the query to delete all rows from the Users table
            string nonQury = "Delete from Users";

            // Create a new Sqlite command using the query string and the database connection
            var comd = new SqliteCommand(nonQury, Database);

            // Execute the command to delete the rows
            var a = comd.ExecuteNonQuery();

            // Dispose of the command object
            comd.Dispose();

            // Return a value indicating whether the deletion was successful
            return a > 0;
        }

    }
}