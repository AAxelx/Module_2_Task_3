using System;
using System.Collections.Generic;
using System.Text;
using Store.Services.Abstractions;
using Store.Services;
using Store.Helpers.Comparers;
using Store.Models.Enums;
using Store.Helpers.Extentions;

namespace Store 
{
    public class Strater
    {
        private readonly IPresentService presentService;
        private readonly ISaladService saladService;

        public Strater()
        {
            presentService = new PresentService();
            saladService = new SaladService();
        }

        public void Run()
        {
            Salad();
            Console.WriteLine("-----------------");
            SweetBox();
        }

        private void Salad()
        {
            var salad = saladService.MakeSalad();
            Array.Sort(salad.Vegetables, new VegetableComparer());

            for (int i = 0; i < salad.Vegetables.Length; i++)
            {
                Console.WriteLine($"Name: {salad.Vegetables[i].Name} Weight: {salad.Vegetables[i].Weight} Calorie: {salad.Vegetables[i].Calorie}");
            }

            Console.WriteLine($"Salad calorie: {salad.Calorie}");

            var vegetables = salad.FindVegetables(TypeOfVegetable.Tomato, 40, 100);

            for (int i = 0; i < vegetables.Length; i++)
            {
                Console.WriteLine($"Name: {vegetables[i].Name} TypeOfVegetable: {vegetables[i].TypeOfVegetable} Price: {vegetables[i].Price}");
            }
        }

        private void SweetBox()
        {
            var sweet = presentService.MakeNewYearSweetBox();
            Array.Sort(sweet.Sweets, new SweetComparer());

            for (int i = 0; i < sweet.Sweets.Length; i++)
            {
                Console.WriteLine($"Name: {sweet.Sweets[i].Name} Weight: {sweet.Sweets[i].Weight} Calorie: {sweet.Sweets[i].Calorie}");
            }

            Console.WriteLine($"Sweet box weight: {sweet.Weight}");

            var sweets = sweet.FindSweets(TypeOfSweet.Flour, 30, 100);

            for (int i = 0; i < sweets.Length; i++)
            {
                Console.WriteLine($"Name: {sweets[i].Name} TypeOfSweet: {sweets[i].TypeOfSweet} Price: {sweets[i].Price}");
            }
        }
    }
}
