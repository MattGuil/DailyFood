using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data.Models
{
    public class CartItem
    {
        public int quantity { get; set; }
        public Dish dish { get; set; }

        public CartItem(Dish dish)
        {
            quantity = 1;
            this.dish = dish;
        }

        public void incrQuantity()
        {
            quantity++;
        }

        public void decrQuantity()
        {
            quantity--;
        }

        public float getPrice()
        {
            return quantity * dish.Price;
        }
    }
}
