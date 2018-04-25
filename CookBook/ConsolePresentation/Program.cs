using System;
using System.Collections.Generic;
using BusinessLogic.Models;
using XmlAccess;

namespace ConsolePresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            //запись в xml
            List<Recipe> recipes1 = new List<Recipe>(5);
            recipes1.Add(new Recipe(1, "Cуп", "Куриный бульон", 2, new List<int>() { 1, 4, 5 }, new List<int>() { 1, 3, 2 }));
            recipes1.Add(new Recipe(2, "Салат", "Оливье", 2, new List<int>() { 3, 5 }, new List<int>() { 5, 8, 1 }));
            recipes1.Add(new Recipe(3, "Горячее", "Котлеты", 2, new List<int>() { 4, 5, 4 }, new List<int>() { 6, 4, 1 }));
            XmlSave.SaveData(recipes1, "C:/Users/a2.pavlova/source/Task2_CookBook/CookBook/XmlAccess/xmlData.xml");

            //
            List<Recipe> recipes2 = new List<Recipe>();
            XmlLoad<List<Recipe>> loadRecipes = new XmlLoad<List<Recipe>>();
            recipes2 = loadRecipes.LoadData("C:/Users/a2.pavlova/source/Task2_CookBook/CookBook/XmlAccess/xmlData.xml");
            foreach (var r in recipes2)
            {
                Console.Write(r.Name);
            }
            Console.Read();
        }
    }
}
