using SQLite;

namespace MyNutritionApp.Data
{
    public interface ISQLiteConnection
    {
        SQLiteConnection GetConnection();
    }
}
