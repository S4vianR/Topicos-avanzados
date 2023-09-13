using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_PizzaBite
{
    public class Pizza
    {
        // Declare constants
        const double _GenericPizzaS3Ing = 85.0;
        const double _GenericPizzaM3Ing = 100.0;
        const double _GenericPizzaL3Ing = 115.0;

        const double _GenericPizzaS6Ing = 95.0;
        const double _GenericPizzaM6Ing = 110.0;
        const double _GenericPizzaL6Ing = 125.0;

        const double _GenericPizzaS9Ing = 105.0;
        const double _GenericPizzaM9Ing = 120.0;
        const double _GenericPizzaL9Ing = 135.0;

        const double _SpecialPizzaS = 100.0;
        const double _SpecialPizzaM = 115.0;
        const double _SpecialPizzaL = 130.0;

        // Enums
        // Pizzas
        public enum PizzaType
        {
            Carbonara,
            Capricciosa,
            Margherita,
            BBQChicken,
            Supreme,
            Regular
        }

        public enum PizzaSize
        {
            Small,
            Medium,
            Large
        }

        public enum Ingredients
        {
            Pepperoni,
            Mushrooms,
            RedBellPeppers,
            BlackOlives,
            Ham,
            Pineapple,
            RedOnion,
            Spinach,
            CherryTomatoes,
            FreshBasil,
            GoatCheese,
            Chorizo
        }

        // Properties
        public PizzaType Type { get; set; }
        public PizzaSize Size { get; set; }
        public List<Ingredients> IngredientsList { get; set; }

        // Constructor
        public Pizza(PizzaType type, PizzaSize size, List<Ingredients> ingredientsList)
        {
            Type = type;
            Size = size;
            IngredientsList = ingredientsList;
        }

        // Methods
        //toString
        public override string ToString()
        {
            // Declare variables
            string pizzaString = "";

            // Add type
            pizzaString += Type.ToString() + " ";

            // Add size
            pizzaString += ", size: " + Size.ToString().ToLower() + " ";

            // If the pizza type is Regular, add ingredients
            if (Type == PizzaType.Regular)
            {
                // Add ingredients
                foreach (Ingredients ingredient in IngredientsList)
                {
                    if (ingredient == IngredientsList.Last())
                    {
                        pizzaString += ingredient.ToString().ToLower() + ".";
                    }
                    else
                    {
                        pizzaString += " with: ";
                        pizzaString += ingredient.ToString().ToLower() + ", ";
                    }
                }
            }

            // Return string
            return pizzaString;
        }

        /*
         * For a pizza of 1-3 ingredients:
         *  - Small: 85
         *  - Medium: 100
         *  - Large: 115
         *  
         *  For a pizza of 4-6 ingredients:
         *  - Small: 95
         *  - Medium: 110
         *  - Large: 125
         *  
         *  For a pizza of 7-9 ingredients:
         *  - Small: 105
         *  - Medium: 120
         *  - Large: 135
         *  
         *  For a special pizza:
         *  - Small: 100
         *  - Medium: 115
         *  - Large: 130
         */

        // Calculate price
        public double CalculatePrice(PizzaType type)
        {
            double price = 0.0;

            switch (type)
            {
                case PizzaType.Carbonara:
                    price = CalculateSpecialPrice(type);
                    break;
                case PizzaType.Capricciosa:
                    price = CalculateSpecialPrice(type);
                    break;
                case PizzaType.Margherita:
                    price = CalculateSpecialPrice(type);
                    break;
                case PizzaType.BBQChicken:
                    price = CalculateSpecialPrice(type);
                    break;
                case PizzaType.Supreme:
                    price = CalculateSpecialPrice(type);
                    break;
                case PizzaType.Regular:
                    price = CalculateChooseIngredientsPrice(type);
                    break;
            }

            return price;
        }


        // Calculate price for Special
        private double CalculateSpecialPrice(PizzaType type)
        {
            double price = 0.0;

            switch (Size)
            {
                case PizzaSize.Small:
                    price = type switch
                    {
                        PizzaType.Carbonara => _SpecialPizzaS,
                        PizzaType.Capricciosa => _SpecialPizzaS,
                        PizzaType.Margherita => _SpecialPizzaS,
                        PizzaType.BBQChicken => _SpecialPizzaS,
                        PizzaType.Supreme => _SpecialPizzaS,
                        _ => price
                    };
                    break;
                case PizzaSize.Medium:
                    price = type switch
                    {
                        PizzaType.Carbonara => _SpecialPizzaM,
                        PizzaType.Capricciosa => _SpecialPizzaM,
                        PizzaType.Margherita => _SpecialPizzaM,
                        PizzaType.BBQChicken => _SpecialPizzaM,
                        PizzaType.Supreme => _SpecialPizzaM,
                        _ => price
                    };
                    break;
                case PizzaSize.Large:
                    price = type switch
                    {
                        PizzaType.Carbonara => _SpecialPizzaL,
                        PizzaType.Capricciosa => _SpecialPizzaL,
                        PizzaType.Margherita => _SpecialPizzaL,
                        PizzaType.BBQChicken => _SpecialPizzaL,
                        PizzaType.Supreme => _SpecialPizzaL,
                        _ => price
                    };
                    break;
            }

            return price;
        }

        // Calculate price for Choose Ingredients
        /*private double CalculateChooseIngredientsPrice(PizzaType type)
        {
            double price = 0.0;

            switch (Size)
            {
                case PizzaSize.Small:
                    price = type switch
                    {
                        PizzaType.Regular when IngredientsList.Count >= 1 && IngredientsList.Count <= 3 => _GenericPizzaS3Ing,
                        PizzaType.Regular when IngredientsList.Count > 3 && IngredientsList.Count <= 6 => _GenericPizzaS6Ing,
                        PizzaType.Regular when IngredientsList.Count > 6 => _GenericPizzaS9Ing,
                        _ => price
                    };
                    break;
                case PizzaSize.Medium:
                    price = type switch
                    {
                        PizzaType.Regular when IngredientsList.Count >= 1 && IngredientsList.Count <= 3 => _GenericPizzaM3Ing,
                        PizzaType.Regular when IngredientsList.Count > 3 && IngredientsList.Count <= 6 => _GenericPizzaM6Ing,
                        PizzaType.Regular when IngredientsList.Count > 6 => _GenericPizzaM9Ing,
                        _ => price
                    };
                    break;
                case PizzaSize.Large:
                    price = type switch
                    {
                        PizzaType.Regular when IngredientsList.Count >= 1 && IngredientsList.Count <= 3 => _GenericPizzaL3Ing,
                        PizzaType.Regular when IngredientsList.Count > 3 && IngredientsList.Count <= 6 => _GenericPizzaL6Ing,
                        PizzaType.Regular when IngredientsList.Count > 6 => _GenericPizzaL9Ing,
                        _ => price
                    };
                    break;
            }

            return price;
        }*/
        private double CalculateChooseIngredientsPrice(PizzaType type)
        {
            double price = 0.0;

            int ingredientCount = IngredientsList.Count;

            switch (Size)
            {
                case PizzaSize.Small:
                    if (ingredientCount >= 1 && ingredientCount <= 3)
                        price = _GenericPizzaS3Ing;
                    else if (ingredientCount <= 6)
                        price = _GenericPizzaS6Ing;
                    else if (ingredientCount > 6)
                        price = _GenericPizzaS9Ing;
                    break;
                case PizzaSize.Medium:
                    if (ingredientCount >= 1 && ingredientCount <= 3)
                        price = _GenericPizzaM3Ing;
                    else if (ingredientCount <= 6)
                        price = _GenericPizzaM6Ing;
                    else if (ingredientCount > 6)
                        price = _GenericPizzaM9Ing;
                    break;
                case PizzaSize.Large:
                    if (ingredientCount >= 1 && ingredientCount <= 3)
                        price = _GenericPizzaL3Ing;
                    else if (ingredientCount <= 6)
                        price = _GenericPizzaL6Ing;
                    else if (ingredientCount > 6)
                        price = _GenericPizzaL9Ing;
                    break;
            }

            return price;
        }
    }
}
