using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data.Models
{
    public class Cart
    {
        private Dictionary<int, Dish> items;
        private int counter = 0;
        
        public Cart()
        {
            items = new Dictionary<int, Dish>();
        }

        public void addItem(Dish dish)
        {
            items.Add(counter, dish);
            counter++;
        }

        public void removeItemWithKey(int itemKey)
        {
            items.Remove(itemKey);
        }

        public Dictionary<int, Dish> getItems()
        {
            return items;
        }

        public float getPrice()
        {
            float price = 0;
            foreach (Dish dish in items.Values)
            {
                price += dish.Price;
            }
            return price;
        }
    }
}
