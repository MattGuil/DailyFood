using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Data.Models;

namespace MiniProject.Data.Services
{
    public class RestaurantDataProvider : RestaurantData
    {
        private static RestaurantDataProvider instance = null;
        private static readonly object padlock = new object();
        private MenuDataProvider menuDataProvider;
        private List<Restaurant> restaurants;

        private RestaurantDataProvider()
        {
            menuDataProvider = MenuDataProvider.Instance();
            restaurants = new List<Restaurant>();
        }

        public static RestaurantDataProvider Instance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new RestaurantDataProvider();
                    instance.restaurants.Add(new Restaurant(0, "", "", instance.menuDataProvider.GetMenu(""), "", 0, (float)0.0, ""));
                    instance.restaurants.Add(new Restaurant(1, "La Monnalisa", "Italian", instance.menuDataProvider.GetMenu("La Monnalisa"), "8 Patriot Square E2 9NF", 30, (float)9.5, "la-monnalisa.jpg"));
                    instance.restaurants.Add(new Restaurant(2, "Alliance", "Mexican", instance.menuDataProvider.GetMenu("Alliance"), "27 Old Gloucester St, 4563", 40, (float)8.0, "alliance.jpg"));
                    instance.restaurants.Add(new Restaurant(3, "Sushi Gold", "Sushi - Japanese", instance.menuDataProvider.GetMenu("Sushi Gold"), "Old Shire Ln EN9 3RX", 25, (float)9.0, "sushi-gold.jpg"));
                    instance.restaurants.Add(new Restaurant(4, "Mr. Pepper", "Vegetarian", instance.menuDataProvider.GetMenu("Mr. Pepper"), "27 Old Gloucester St, 4563", 30, (float)9.5, "mr-pepper.jpg"));
                    instance.restaurants.Add(new Restaurant(5, "Dragon Tower", "Chinese", instance.menuDataProvider.GetMenu("Dragon Tower"), "22 Hertsmere Rd E14 4ED", 50, (float)8.0, "dragon-tower.jpg"));
                    instance.restaurants.Add(new Restaurant(6, "Bella Napoli", "Pizza - Italian", instance.menuDataProvider.GetMenu("Bella Napoli"), "135 Newtownards Road BT4", 45, (float)8.5, "bella-napoli.jpg"));
                }
                return instance;
            }
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return restaurants.Where(item => item.id != 0);
        }

        public Restaurant GetRestaurantById(int id)
        {
            return restaurants.Where(item => item.id == id).ToList()[0];
        }
    }
}
