using ProjectApplication.Data.Interfaces;
using ProjectApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ProjectApplication.Data.Repository
{
    public class Ordersrepository : IAllOrders
    {
        private readonly appDBcontent appDBcontent;
        private readonly ShopCart shopCart;

        public Ordersrepository(appDBcontent appDBcontent, ShopCart shopCart)
        {
            this.appDBcontent = appDBcontent;
            this.shopCart = shopCart;
        }

        [Authorize]
        public void createOrder(Order order)
        {
            
            order.oredertime = DateTime.Now;
            appDBcontent.Order.Add(order);

            var items = shopCart.listShopitems;

            foreach(var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    MilkId = el.milk.id,
                    OrderId = order.id,
                    price = el.milk.price
                };
                appDBcontent.OrderDetail.Add(orderDetail);
            }
            appDBcontent.SaveChanges();
        }
    }
}
