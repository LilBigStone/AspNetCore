using ProjectApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApplication.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
