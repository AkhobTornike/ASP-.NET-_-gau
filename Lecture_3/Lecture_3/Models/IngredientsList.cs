using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lecture_3.Models
{
    public class IngredientsList
    {
        public static List<Ingredient> IngredientList = new List<Ingredient>()
        {
            new Ingredient
            {
                Id = 0,
                Name = "Lasagna",
                Image = "/Content/Images/Image1.png", 
                Ingredients = "Lasagna sheets, Tomato sauce, Cheese, Vegetables, Meat",
                Description = "A comforting lasagna made with layers of pasta, rich tomato sauce, melted cheese, and your choice of vegetables and meat.",
                VideoLink = "https://example.com/lasagna-video" 
            },
            new Ingredient
            {
                Id = 1,
                Name = "Grilled Salmon with Asparagus",
                Image = "/Content/Images/Image2.jpeg", 
                Ingredients = "Salmon, Asparagus, Lemon, Dill, Olive Oil, Cherry Tomatoes",
                Description = "A light and healthy dish of grilled salmon served with fresh asparagus, lemon, and cherry tomatoes.",
                VideoLink = "https://example.com/salmon-video"
            },
            new Ingredient
            {
                Id = 2,
                Name = "Some Soupe",
                Image = "/Content/Images/Image3.jpeg",
                Ingredients = "Rice, Vegetables, Soy Sauce, Tofu",
                Description = "A delicious vegan stir-fry made with rice, vegetables, and tofu, flavored with soy sauce for a savory touch.",
                VideoLink = "https://example.com/recipe3-video"
            },
        };
          
    }
}