using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNutritionApp
{
    public class Meal
    {
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
