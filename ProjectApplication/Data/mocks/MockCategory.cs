using System;
using System.Collections.Generic;
using System.Linq;
using ProjectApplication.Data.Interfaces;
using System.Threading.Tasks;
using ProjectApplication.Data.Models;

namespace ProjectApplication.Data.mocks
{
    public class MockCategory : IMilkCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category> {
                    new Category { categoryName = "Электро", desc = "Современный вид транспорта" },
                    new Category { categoryName = "Классика", desc = "Классические авто" }
                };
                
            }
        } 
    }
}
