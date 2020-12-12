using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApplication.Data.Models;

namespace ProjectApplication.Data.Interfaces
{
    public interface IAllMilks
    {
        IEnumerable<MilkProd> Milks { get; }
        IEnumerable<MilkProd> getFavMilks { get; }
        MilkProd getObjectMilk(int carId);
    }
}
