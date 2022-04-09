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

        public ActionResult Cart(int? _itemKey, int? _action)
        {
            int itemKey = _itemKey ?? -1;
            int action = _action ?? 0;

            if (itemKey != -1)
            {
                Cart cart = Session["cart"] as Cart;
                if(action != 0)
                {
                    if(action == 1)
                    {
                        cart.getItem(itemKey).incrQuantity();
                    } else if(action == -1)
                    {
                        if(cart.getItem(itemKey).quantity > 1)
                        {
                            cart.getItem(itemKey).decrQuantity();
                        } else
                        {
                            cart.removeItemWithKey(itemKey);
                        }
                    }
                }
                Session["cart"] = cart;
            }

            var model = Session["cart"] as Cart;

            return View(model);
        }
    }
}