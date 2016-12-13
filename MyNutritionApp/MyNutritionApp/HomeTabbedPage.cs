using MyNutritionApp.Data;
using SQLite;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace MyNutritionApp
{
    public class HomeTabbedPage : TabbedPage
    {

        ObservableCollection<Meal> Meals;

        public HomeTabbedPage()
        {
            SQLiteConnection connection = DependencyService.Get<ISQLiteConnection>().GetConnection();

            MealDAO dao = new MealDAO(connection);

            Meals = new ObservableCollection<Meal>();

            ListMeals listMealsView = new ListMeals(Meals);
            IncludeMeal includeMealView = new IncludeMeal(Meals, dao);

            this.Children.Add(listMealsView);
            this.Children.Add(includeMealView);
        }
    }
}
