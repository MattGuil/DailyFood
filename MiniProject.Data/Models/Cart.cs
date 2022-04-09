using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data.Models
{
    public class Cart
    {
        private Dictionary<int, CartItem> items;
        private int counter = 0;
        
        public Cart()
        {
            items = new Dictionary<int, CartItem>();
        }

        public void addItem(Dish dish)
        {
            foreach(CartItem item in items.Values)
            {
                if(item.dish.Id == dish.Id)
                {
                    item.incrQuantity();
                    return;
                }
            }

            items.Add(counter, new CartItem(dish));
            counter++;
        }

        public CartItem getItem(int key)
        {
            return items[key];
        }

        public void removeItemWithKey(int itemKey)
        {
            if(items[itemKey].quantity > 1)
            {
                items[itemKey].decrQuantity();
            } else
            {
                items.Remove(itemKey);
            }
        }

        public Dictionary<int, CartItem> getItems()
        {
            return items;
        }

        public float getPrice()
        {
            float price = 0;
            foreach (CartItem item in items.Values)
            {
                price += item.getPrice();
            }
            return price;
        }
    }
}
