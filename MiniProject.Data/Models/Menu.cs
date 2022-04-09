using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Data.Models
{
    public class Menu
    {
        private List<Dish> dishes;

        public Menu(List<Dish> dishes)
        {
            this.dishes = dishes;
        }

        public List<Dish> getDishes()
        {
            return dishes;
        }
    }
}
