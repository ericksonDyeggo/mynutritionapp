using System;
using System.Collections.ObjectModel;
using SQLite;

namespace MyNutritionApp.Data
{
    public class MealDAO
    {
        private SQLiteConnection Connection;

        public MealDAO(SQLiteConnection connection)
        {
            this.Connection = connection;

            connection.CreateTable<Meal>();
        }

        private ObservableCollection<Meal> list;

        public ObservableCollection<Meal> List
        {
            get
            {
                if (list == null)
                    list = getAll();
                return list;
            }
            set
            {
                list = value;
            }
        }

        public void Save(Meal meal)
        {
            Connection.Insert(meal);
            list.Add(meal);
        }

        private ObservableCollection<Meal> getAll()
        {
            ObservableCollection<Meal> meals = new ObservableCollection<Meal>(Connection.Table<Meal>());

            return meals;
        }

        internal void Remove(Meal meal)
        {
            Connection.Delete<Meal>(meal.Id);
            list.Remove(meal);
        }
    }
}
