using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data.Models
{
    public class Restaurant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string typeOfFood { get; set; }
        public Menu menu { get; set; }
        public string address { get; set; }
        public int reduction { get; set; }
        public float stars { get; set; }
        public string image { get; set; }

        public Restaurant(int id, string name, string typeOfFood, Menu menu, string address, int reduction, float stars, string image)
        {
            this.id = id;
            this.name = name;
            this.typeOfFood = typeOfFood;
            this.menu = menu;
            this.address = address;
            this.reduction = reduction;
            this.stars = stars;
            this.image = image;
        }

        public float getAveragePrice()
        {
            int count = 0;
            float sumPrices = 0;
            foreach (Dish dish in menu.getDishes())
            {
                sumPrices += dish.Price;
                count++;
            }
            return sumPrices / count;
        }
    }
}
