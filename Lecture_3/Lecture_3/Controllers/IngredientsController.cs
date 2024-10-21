using Lecture_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lecture_3.Controllers
{
    public class IngredientsController : Controller
    {
        // GET: Ingredients
        public ActionResult Ingredients()
        {
            var ingredients = IngredientsList.IngredientList;

            return View(ingredients);
        }

        public ActionResult IngredientDetail(int id)
        {
            var ingredient = IngredientsList.IngredientList[id];
            return View(ingredient);
        }
    }
}