﻿using MealServices.BusinessLayer.Domain;
using MealServices.Shared;
using MealServices.Shared.Enumerations;
using MealServices.Shared.TransfertObjects;
using System;
using System.Linq;

namespace MealServices.BusinessLayer.Extentions
{
    public static class MealExtensions
    {
        //public static MealTO ToBTO(this Sandwich Sandwich, Language Langue)
        //{
        //    return new MealTO
        //    {
        //        Id = Sandwich.Id,
        //        Name = Sandwich.ToString(Langue),
        //        Ingredients = String.Join(" - ", Sandwich.Ingredients.Select(x => x.ToString(Langue))),
        //        //Supplier = Sandwich.Supplier.ToTransfertObject()
        //    };
        //}

        public static Meal ToDomain(this MealTO MealTO)
        {
            return new Meal(MealTO.Name, MealTO.Supplier.ToDomain())
            {
                Id = MealTO.Id,
                Ingredients = MealTO.Ingredients.Select(x => x.ToDomain()).ToList(),
                MealType = MealTO.MealType
            };
        }

        public static MealTO ToTransfertObject(this Meal Meal)
        {
            return new MealTO
            {
                Id = Meal.Id,
                Name = Meal.Name,
                MealType = Meal.MealType,
                Ingredients = Meal.Ingredients.Select(x => x.ToTransfertObject()).ToList(),
                Supplier = Meal.Supplier.ToTransfertObject()
            };
        }
    }
}