using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiniProject.Data.Models;

namespace MiniProject.Data.Services
{
    public class MenuDataProvider : MenuData
    {
        private static MenuDataProvider instance = null;
        private static readonly object padlock = new object();
        private DishDataProvider dishDataProvider;
        private Dictionary<string, Menu> MenusMap;

        private MenuDataProvider()
        {
            dishDataProvider = DishDataProvider.Instance();
            MenusMap = new Dictionary<string, Menu>();
        }

        public static MenuDataProvider Instance()
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new MenuDataProvider();
                    instance.MenusMap[""] = new Menu(instance.dishDataProvider.GetDishes(""));
                    instance.MenusMap["La Monnalisa"] = new Menu(instance.dishDataProvider.GetDishes("La Monnalisa"));
                    instance.MenusMap["Alliance"] = new Menu(instance.dishDataProvider.GetDishes("Alliance"));
                    instance.MenusMap["Sushi Gold"] = new Menu(instance.dishDataProvider.GetDishes("Sushi Gold"));
                    instance.MenusMap["Mr. Pepper"] = new Menu(instance.dishDataProvider.GetDishes("Mr. Pepper"));
                    instance.MenusMap["Dragon Tower"] = new Menu(instance.dishDataProvider.GetDishes("Dragon Tower"));
                    instance.MenusMap["Bella Napoli"] = new Menu(instance.dishDataProvider.GetDishes("Bella Napoli"));
                }
                return instance;
            }
        }

        public Menu GetMenu(string restaurant)
        {
            return MenusMap[restaurant];
        }
    }
}
