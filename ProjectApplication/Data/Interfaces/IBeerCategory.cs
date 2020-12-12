using System;
using System.Collections.Generic;
using System.Linq;
using ProjectApplication.Data.Models;
using System.Threading.Tasks;

namespace ProjectApplication.Data.Interfaces
{
    public interface IMilkCategory
    {
        IEnumerable<Category> AllCategories{get; }
        
            
    }
}
