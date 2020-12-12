using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApplication.Data.Models;

namespace ProjectApplication.ViewModels
{
    public class MilksListViewModel
    {
        public IEnumerable<MilkProd> allMilks { get; set; }

        public string currCategory { get; set; }
    }
}
