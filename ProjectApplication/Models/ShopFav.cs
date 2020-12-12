using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApplication.Data.Models
{
    public class ShopFav
    {
        public int id { get; set; }
        public MilkProd milk { get; set; }
        public int price { get; set; }

        public string ShopCartid { get; set; }

    }
}
