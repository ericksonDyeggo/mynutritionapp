using MyNutritionApp.Data;
using MyNutritionApp.Droid;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteConnectionAndroid))]
namespace MyNutritionApp.Droid
{
    class SQLiteConnectionAndroid : ISQLiteConnection
    {
        public SQLiteConnection GetConnection()
        {
            var filename = "MyNutritionApp.db3";

            var directory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

            var path = Path.Combine(directory, filename);

            SQLiteConnection conn = null;

            try
            {
                conn = new SQLiteConnection(path);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return conn;
        }
    }
}