using SQLite;
using System;

namespace MyNutritionApp
{
    public class Meal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public String Description { get; set; }
        public Double Calories { get; set; }

        public Meal()
        {
        }

        public Meal (String Description, Double Calories)
        {
            this.Description = Description;
            this.Calories = Calories;
        }
    }
}
