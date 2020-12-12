using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApplication.Data.Models
{
    public class ShopCart
    {
        private readonly appDBcontent appDbContent;

        public ShopCart(appDBcontent appDBContent)
        {
            this.appDbContent = appDBContent;
        }
        public string ShopCartId { get; set; }

        public List<ShopFav> listShopitems { get; set; }

        public static ShopCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<appDBcontent>();
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", shopCartId);
            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        public void AddToCart(MilkProd milk)
        {
            this.appDbContent.ShopFav.Add(new ShopFav{
                ShopCartid = ShopCartId,
                milk = milk,
                price = milk.price
            });
            appDbContent.SaveChanges();
        }

        public List<ShopFav> getShopItems()
        {
            return appDbContent.ShopFav.Where(c => c.ShopCartid == ShopCartId).Include(s => s.milk).ToList();
        }
    }
}
