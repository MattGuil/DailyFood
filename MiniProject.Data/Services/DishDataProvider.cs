using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Data.Models;

namespace MiniProject.Data.Services
{
    public class DishDataProvider
    {
        private static DishDataProvider instance = null;
        private static readonly object padlock = new object();
        List<Dish> dishes = new List<Dish>();

        private DishDataProvider()
        {

        }

        public static DishDataProvider Instance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new DishDataProvider();

                    instance.dishes.Add(new Dish(1, "La Monnalisa", "[La Monnalisa] Starter 1", "starter.jpg", DishCategory.Starter, "Starter 1 at La Monnalisa", (float)5.0));
                    instance.dishes.Add(new Dish(2, "La Monnalisa", "[La Monnalisa] Starter 2", "starter.jpg", DishCategory.Starter, "Starter 2 at La Monnalisa", (float)5.0));
                    instance.dishes.Add(new Dish(3, "La Monnalisa", "[La Monnalisa] MainPlate 1", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 1 at La Monnalisa", (float)10.0));
                    instance.dishes.Add(new Dish(4, "La Monnalisa", "[La Monnalisa] MainPlate 2", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 2 at La Monnalisa", (float)10.0));
                    instance.dishes.Add(new Dish(5, "La Monnalisa", "[La Monnalisa] Dessert 1", "dessert.jpg", DishCategory.Dessert, "Dessert 1 at La Monnalisa", (float)7.0));
                    instance.dishes.Add(new Dish(6, "La Monnalisa", "[La Monnalisa] Dessert 2", "dessert.jpg", DishCategory.Dessert, "Dessert 2 at La Monnalisa", (float)7.0));
                    instance.dishes.Add(new Dish(7, "La Monnalisa", "[La Monnalisa] Drink 1", "drink.jpg", DishCategory.Drink, "Drink 1 at La Monnalisa", (float)3.0));
                    instance.dishes.Add(new Dish(8, "La Monnalisa", "[La Monnalisa] Drink 2", "drink.jpg", DishCategory.Drink, "Drink 2 at La Monnalisa", (float)3.0));

                    instance.dishes.Add(new Dish(9, "Alliance", "[Alliance] Starter 1", "starter.jpg", DishCategory.Starter, "Starter 1 at Alliance", (float)5.0));
                    instance.dishes.Add(new Dish(10, "Alliance", "[Alliance] Starter 2", "starter.jpg", DishCategory.Starter, "Starter 2 at Alliance", (float)5.0));
                    instance.dishes.Add(new Dish(11, "Alliance", "[Alliance] MainPlate 1", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 1 at Alliance", (float)10.0));
                    instance.dishes.Add(new Dish(12, "Alliance", "[Alliance] MainPlate 2", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 2 at Alliance", (float)10.0));
                    instance.dishes.Add(new Dish(13, "Alliance", "[Alliance] Dessert 1", "dessert.jpg", DishCategory.Dessert, "Dessert 1 at Alliance", (float)7.0));
                    instance.dishes.Add(new Dish(14, "Alliance", "[Alliance] Dessert 2", "dessert.jpg", DishCategory.Dessert, "Dessert 2 at Alliance", (float)7.0));
                    instance.dishes.Add(new Dish(15, "Alliance", "[Alliance] Drink 1", "drink.jpg", DishCategory.Drink, "Drink 1 at Alliance", (float)3.0));
                    instance.dishes.Add(new Dish(16, "Alliance", "[Alliance] Drink 2", "drink.jpg", DishCategory.Drink, "Drink 2 at Alliance", (float)3.0));

                    instance.dishes.Add(new Dish(17, "Sushi Gold", "[Sushi Gold] Starter 1", "starter.jpg", DishCategory.Starter, "Starter 1 at Sushi Gold", (float)5.0));
                    instance.dishes.Add(new Dish(18, "Sushi Gold", "[Sushi Gold] Starter 2", "starter.jpg", DishCategory.Starter, "Starter 2 at Sushi Gold", (float)5.0));
                    instance.dishes.Add(new Dish(19, "Sushi Gold", "[Sushi Gold] MainPlate 1", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 1 at Sushi Gold", (float)10.0));
                    instance.dishes.Add(new Dish(20, "Sushi Gold", "[Sushi Gold] MainPlate 2", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 2 at Sushi Gold", (float)10.0));
                    instance.dishes.Add(new Dish(21, "Sushi Gold", "[Sushi Gold] Dessert 1", "dessert.jpg", DishCategory.Dessert, "Dessert 1 at Sushi Gold", (float)7.0));
                    instance.dishes.Add(new Dish(22, "Sushi Gold", "[Sushi Gold] Dessert 2", "dessert.jpg", DishCategory.Dessert, "Dessert 2 at Sushi Gold", (float)7.0));
                    instance.dishes.Add(new Dish(23, "Sushi Gold", "[Sushi Gold] Drink 1", "drink.jpg", DishCategory.Drink, "Drink 1 at Sushi Gold", (float)3.0));
                    instance.dishes.Add(new Dish(24, "Sushi Gold", "[Sushi Gold] Drink 2", "drink.jpg", DishCategory.Drink, "Drink 2 at Sushi Gold", (float)3.0));

                    instance.dishes.Add(new Dish(25, "Mr. Pepper", "[Mr. Pepper] Starter 1", "starter.jpg", DishCategory.Starter, "Starter 1 at Mr. Pepper", (float)5.0));
                    instance.dishes.Add(new Dish(26, "Mr. Pepper", "[Mr. Pepper] Starter 2", "starter.jpg", DishCategory.Starter, "Starter 2 at Mr. Pepper", (float)5.0));
                    instance.dishes.Add(new Dish(27, "Mr. Pepper", "[Mr. Pepper] MainPlate 1", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 1 at Mr. Pepper", (float)10.0));
                    instance.dishes.Add(new Dish(28, "Mr. Pepper", "[Mr. Pepper] MainPlate 2", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 2 at Mr. Pepper", (float)10.0));
                    instance.dishes.Add(new Dish(29, "Mr. Pepper", "[Mr. Pepper] Dessert 1", "dessert.jpg", DishCategory.Dessert, "Dessert 1 at Mr. Pepper", (float)7.0));
                    instance.dishes.Add(new Dish(30, "Mr. Pepper", "[Mr. Pepper] Dessert 2", "dessert.jpg", DishCategory.Dessert, "Dessert 2 at Mr. Pepper", (float)7.0));
                    instance.dishes.Add(new Dish(31, "Mr. Pepper", "[Mr. Pepper] Drink 1", "drink.jpg", DishCategory.Drink, "Drink 1 at Mr. Pepper", (float)3.0));
                    instance.dishes.Add(new Dish(32, "Mr. Pepper", "[Mr. Pepper] Drink 2", "drink.jpg", DishCategory.Drink, "Drink 2 at Mr. Pepper", (float)3.0));

                    instance.dishes.Add(new Dish(33, "Dragon Tower", "[Dragon Tower] Starter 1", "starter.jpg", DishCategory.Starter, "Starter 1 at Dragon Tower", (float)5.0));
                    instance.dishes.Add(new Dish(34, "Dragon Tower", "[Dragon Tower] Starter 2", "starter.jpg", DishCategory.Starter, "Starter 2 at Dragon Tower", (float)5.0));
                    instance.dishes.Add(new Dish(35, "Dragon Tower", "[Dragon Tower] MainPlate 1", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 1 at Dragon Tower", (float)10.0));
                    instance.dishes.Add(new Dish(36, "Dragon Tower", "[Dragon Tower] MainPlate 2", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 2 at Dragon Tower", (float)10.0));
                    instance.dishes.Add(new Dish(37, "Dragon Tower", "[Dragon Tower] Dessert 1", "dessert.jpg", DishCategory.Dessert, "Dessert 1 at Dragon Tower", (float)7.0));
                    instance.dishes.Add(new Dish(38, "Dragon Tower", "[Dragon Tower] Dessert 2", "dessert.jpg", DishCategory.Dessert, "Dessert 2 at Dragon Tower", (float)7.0));
                    instance.dishes.Add(new Dish(39, "Dragon Tower", "[Dragon Tower] Drink 1", "drink.jpg", DishCategory.Drink, "Drink 1 at Dragon Tower", (float)3.0));
                    instance.dishes.Add(new Dish(40, "Dragon Tower", "[Dragon Tower] Drink 2", "drink.jpg", DishCategory.Drink, "Drink 2 at Dragon Tower", (float)3.0));

                    instance.dishes.Add(new Dish(41, "Bella Napoli", "[Bella Napoli] Starter 1", "starter.jpg", DishCategory.Starter, "Starter 1 at Bella Napoli", (float)5.0));
                    instance.dishes.Add(new Dish(42, "Bella Napoli", "[Bella Napoli] Starter 2", "starter.jpg", DishCategory.Starter, "Starter 2 at Bella Napoli", (float)5.0));
                    instance.dishes.Add(new Dish(43, "Bella Napoli", "[Bella Napoli] MainPlate 1", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 1 at Bella Napoli", (float)10.0));
                    instance.dishes.Add(new Dish(44, "Bella Napoli", "[Bella Napoli] MainPlate 2", "mainplate.jpg", DishCategory.MainPlate, "MainPlate 2 at Bella Napoli", (float)10.0));
                    instance.dishes.Add(new Dish(45, "Bella Napoli", "[Bella Napoli] Dessert 1", "dessert.jpg", DishCategory.Dessert, "Dessert 1 at Bella Napoli", (float)7.0));
                    instance.dishes.Add(new Dish(46, "Bella Napoli", "[Bella Napoli] Dessert 2", "dessert.jpg", DishCategory.Dessert, "Dessert 2 at Bella Napoli", (float)7.0));
                    instance.dishes.Add(new Dish(47, "Bella Napoli", "[Bella Napoli] Drink 1", "drink.jpg", DishCategory.Drink, "Drink 1 at Bella Napoli", (float)3.0));
                    instance.dishes.Add(new Dish(48, "Bella Napoli", "[Bella Napoli] Drink 2", "drink.jpg", DishCategory.Drink, "Drink 2 at Bella Napoli", (float)3.0));
                }
                return instance;
            }
        }

        public List<Dish> GetDishes(string restaurant)
        {
            if(restaurant == "")
            {
                return dishes;
            } else
            {
                return dishes.Where(item => item.restaurant == restaurant).ToList();
            }
        }

        public Dish GetDishById(int id)
        {
            return dishes.Where(item => item.Id == id).ToList()[0];
        }
    }
}
