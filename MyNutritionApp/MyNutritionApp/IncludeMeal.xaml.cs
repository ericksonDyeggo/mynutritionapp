using MyNutritionApp.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyNutritionApp
{
    public partial class IncludeMeal : ContentPage
    {

        public MealDAO Dao;

        public IncludeMeal( MealDAO dao)
        {
            this.Dao = dao;
            InitializeComponent();
        }

        public void UpdateCalories(Object sender, EventArgs e)
        {
            double value = calorieCounter.Value;

            labelCalories.Text = value.ToString();
        }

        public void SaveEntry(Object sebder, EventArgs e)
        {
            String description = entryDescription.Text;

            Double calories = calorieCounter.Value;

            Meal meal = new Meal(description, calories);
            
            StringBuilder sb = new StringBuilder();

            Dao.Save(meal);

            sb.Append("A refeição ");
            sb.Append(description);
            sb.Append(" de ");
            sb.Append(calories);
            sb.Append(" calorias foi salva com sucesso!");

            DisplayAlert("Salvar Refeição", sb.ToString(), "Ok");

            Clear();
        }

        public void Clear()
        {
            entryDescription.Text = "";
            labelCalories.Text = "0";
            calorieCounter.Value = 0.0;
        }
    }
}
