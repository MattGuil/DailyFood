using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiniProject.Data.Models;
using MiniProject.Data.Services;
using System.Web.UI;

namespace MiniProject.Web.Controllers
{
    public class HomeController : Controller
    {
        RestaurantDataProvider restaurantDataProvider;
        DishDataProvider dishDataProvider;

        public ActionResult Restaurants()
        {
            if (Session["cart"] == null)
            {
                Session["cart"] = new Cart();
            }

            restaurantDataProvider = RestaurantDataProvider.Instance();
            var model = restaurantDataProvider.GetAllRestaurants();
            return View(model);
        }

        public ActionResult Dishes(int id)
        {
            restaurantDataProvider = RestaurantDataProvider.Instance();
            var model = restaurantDataProvider.GetRestaurantById(id);
            return View(model);
        }

        public ActionResult DishDetails(int dishId, int addToCart)
        {
            dishDataProvider = DishDataProvider.Instance();
            Dish dish = dishDataProvider.GetDishById(dishId);

            if (addToCart == 1)
            {
                Cart cart = Session["cart"] as Cart;
                cart.addItem(dish);
                Session["cart"] = cart;
                dish.isAddedToCart = true;
            } else
            {
                dish.isAddedToCart = false;
            }

            var model = dish;

            return View(model);
        }

        public ActionResult Cart(int? _itemKeyToRemove)
        {
            int itemKeyToRemove = _itemKeyToRemove ?? -1;

            if (itemKeyToRemove != -1)
            {
                Cart cart = Session["cart"] as Cart;
                cart.removeItemWithKey(itemKeyToRemove);
                Session["cart"] = cart;
            }

            var model = Session["cart"] as Cart;

            return View(model);
        }
    }
}