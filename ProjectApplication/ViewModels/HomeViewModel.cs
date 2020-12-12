using ProjectApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApplication.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<MilkProd> favMilks { get; set; }
    }
}
