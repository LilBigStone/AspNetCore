using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApplication.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int OrderId { get; set; }
        public int MilkId { get; set; }
        public uint price { get; set; }
        public virtual MilkProd milk { get; set; }
        public virtual Order order { get; set; }

    }
}
