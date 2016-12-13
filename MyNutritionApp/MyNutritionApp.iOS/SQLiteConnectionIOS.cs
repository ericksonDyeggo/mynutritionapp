using System;
using MyNutritionApp.Data;
using SQLite;
using System.IO;
using MyNutritionApp.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteConnectionIOS))]
namespace MyNutritionApp.iOS
{
    public class SQLiteConnectionIOS : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "MyNutritionApp.db3";

            var directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var path = Path.Combine(directory, "..", "Library", filename);

            return new SQLiteConnection(path);
        }
    }
}
