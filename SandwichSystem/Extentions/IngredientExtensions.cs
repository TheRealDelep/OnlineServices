﻿using SandwichSystem.BusinessLayer.Domain;
using SandwichSystem.Shared;
using SandwichSystem.Shared.BTO;
using SandwichSystem.Shared.DTO;
using System;
using System.Linq;

namespace SandwichSystem.BusinessLayer.Extentions
{
    public static class IngredientExtensions
    {
        public static Ingredient ToDomain(this string ingredientBTO, Language Langue)
        {
            //TO IMPLEMENT
            return new Ingredient(null, false);
        }
        public static Ingredient ToDomain(this IngredientDTO IngredientDTO)
        {
            return new Ingredient(IngredientDTO.Name, IngredientDTO.IsAllergene);
        }
    }
}
