using System;
using System.Collections.Generic;

namespace builder
{
    class Burger
    {
        private List<string> mIngredients;

        public Burger()
        {
            mIngredients = new List<string>();
        }

        public Burger AddIngredient(string aIngredient)
        {
            mIngredients.Add(aIngredient);
            Console.WriteLine($"adicionando {aIngredient}...");

            return this;
        }
    }
}