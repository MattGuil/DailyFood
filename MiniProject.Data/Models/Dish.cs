using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string restaurant { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public DishCategory Category { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public bool isAddedToCart { get; set; }

        public Dish(int Id, string restaurant, string Name, string Image, DishCategory Category, string Description, float Price)
        {
            this.Id = Id;
            this.restaurant = restaurant;
            this.Name = Name;
            this.Image = Image;
            this.Category = Category;
            this.Description = Description;
            this.Price = Price;
            this.isAddedToCart = false;
        }

        public static Array getTypes()
        {
            return Enum.GetValues(typeof(DishCategory));
        }
    }
}
