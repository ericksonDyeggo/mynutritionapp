using MyNutritionApp.Data;
using SQLite;

using Xamarin.Forms;

namespace MyNutritionApp
{
    public class HomeTabbedPage : TabbedPage
    {

        public HomeTabbedPage()
        {
            SQLiteConnection connection = DependencyService.Get<ISQLiteConnection>().GetConnection();

            MealDAO dao = new MealDAO(connection);

            ListMeals listMealsView = new ListMeals(dao);
            IncludeMeal includeMealView = new IncludeMeal(dao);

            this.Children.Add(listMealsView);
            this.Children.Add(includeMealView);
        }
    }
}
