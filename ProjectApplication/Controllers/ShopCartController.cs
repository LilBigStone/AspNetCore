using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectApplication.Data.Interfaces;
using ProjectApplication.Data.Models;
using ProjectApplication.ViewModels;

namespace ProjectApplication.Controllers
{
    public class ShopCartController: Controller
    {
        private readonly IAllMilks _milkRep;
        private readonly ShopCart _shopCart;

        public ShopCartController(IAllMilks milkRep, ShopCart shopCart)
        {
            _milkRep = milkRep;
            _shopCart = shopCart;
        }

        public ViewResult Index()
        {
            var items = _shopCart.getShopItems();
            _shopCart.listShopitems = items;

            var obj = new ShopCartViewModel
            {
                shopCart = _shopCart
            };

            return View(obj);

        }
        
        public RedirectToActionResult addToCart(int id)
        {Console.Write("OK");
            var item = _milkRep.Milks.FirstOrDefault(i => i.id == id);

            if (item != null){  
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");

        }
    }
}
