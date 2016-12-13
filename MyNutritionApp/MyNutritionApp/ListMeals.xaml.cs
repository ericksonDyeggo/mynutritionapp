using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyNutritionApp
{
    public partial class ListMeals : ContentPage
    {

        public ObservableCollection<Meal> Meals { get; set; }

        public ListMeals(ObservableCollection<Meal> Meals)
        {
            this.Meals = Meals;
            BindingContext = this;
            InitializeComponent();
        }

        public async void ItemAction(Object sender, ItemTappedEventArgs e)
        {
            Meal meal = (Meal)e.Item;

            var confirm = await DisplayAlert("Remover Item", "Tem certesa que deseja remover a refeição " + meal.Description + "?'", "Sim", "Não");

            if (confirm)
            {
                Meals.Remove(meal);

                await DisplayAlert("Remover item", "Refeição " + meal.Description + " removida com sucesso!", "Ok");
            }
        }
    }
}
