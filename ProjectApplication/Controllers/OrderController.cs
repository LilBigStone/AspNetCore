using Microsoft.AspNetCore.Mvc;
using ProjectApplication.Data.Interfaces;
using ProjectApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApplication.Controllers
{
    public class OrderController: Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }

        public IActionResult Chekout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Chekout(Order order)
        {
            shopCart.listShopitems = shopCart.getShopItems();
            if(shopCart.listShopitems.Count == 0)
            {
                ModelState.AddModelError("","Корзина не должна быть пуста");
            }
            if (ModelState.IsValid){
                if (User.Identity.IsAuthenticated)
                {
                    order.email = User.Identity.Name;
                }  
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            
            return View();
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
