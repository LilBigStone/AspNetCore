using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApplication.Data.Interfaces;
using ProjectApplication.Data.Interfaces;
using ProjectApplication.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectApplication.Data.Repository
{
    public class CategoryRepository : IMilkCategory
    {

        private readonly appDBcontent appDbContent;

        public CategoryRepository(appDBcontent appDBContent)
        {
            this.appDbContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDbContent.Category;
    }
}
