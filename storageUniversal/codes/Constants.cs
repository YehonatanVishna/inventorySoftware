using System.IO;
using Windows.Storage;

public static class Constants
{
    /// <summary>
    /// this code segment defines a few constants nessesry to create sql lite data base
    /// </summary>
    public const string DatabaseFilename = "TodoSQLite.db3";
    public static string DatabasePath =>
        Path.Combine(ApplicationData.Current.LocalFolder.Path, "sqliteSample.db");
}