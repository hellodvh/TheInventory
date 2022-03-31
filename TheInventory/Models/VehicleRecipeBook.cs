﻿using TheInventory.Services;

namespace TheInventory.Models
{
    public class VehicleRecipeBook
    {
        public List<Recipe> Recipes = new List<Recipe>();

        public VehicleRecipeBook()
        {
            Recipes = Database.GetAllRecipes();
        }

        public bool CraftRecipe(string name, int count, List<string> ingredient, string verify)
        {
            Console.WriteLine(ingredient[0]);
            return Database.CraftRecipe(name, count, ingredient, verify);
        }
    }
}
