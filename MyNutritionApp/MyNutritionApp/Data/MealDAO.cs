using SQLite;

namespace MyNutritionApp.Data
{
    public class MealDAO
    {
        private SQLiteConnection Connection;

        public MealDAO(SQLiteConnection connection)
        {
            this.Connection = connection;
        }

        internal void Save(Meal meal)
        {
            Connection.Insert(meal);
        }
    }
}
