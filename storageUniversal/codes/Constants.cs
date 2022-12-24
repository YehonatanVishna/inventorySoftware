using System.IO;
using Windows.Storage;

public static class Constants
{
    /// <summary>
    /// this code segment defines a few constants nessesry to create sql lite data base
    /// </summary>
    //the filename in which the db will be saved
    //שם הקובץ בו ישמר מסד הנתונים
    public const string DatabaseFilename = "TodoSQLite.db3";
    //the path to the db file
    //המסלול לקובץ המכיל את מסד הנתונים
    public static string DatabasePath =>
        Path.Combine(ApplicationData.Current.LocalFolder.Path, "sqliteSample.db");
}