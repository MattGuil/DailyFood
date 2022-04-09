using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Data.Models;

namespace MiniProject.Data.Services
{
    public interface DishData
    {
        IEnumerable<Dish> GetDishes(string restaurant);
    }
}
