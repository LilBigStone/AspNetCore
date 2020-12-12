using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApplication.Data.Interfaces;
using ProjectApplication.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectApplication.Data.Repository
{
    
    public class CarRepository : IAllMilks
    {
        private readonly appDBcontent appDbContent;

        public CarRepository(appDBcontent appDBContent)
        {
            this.appDbContent = appDBContent;
        }
        
        public IEnumerable<MilkProd> Milks => appDbContent.MilkProds.Include(c => c.Category);
        public IEnumerable<MilkProd> getFavMilks => appDbContent.MilkProds.Where(p => p.isFavourite).Include(c => c.Category);
        public MilkProd getObjectMilk(int milkId) => appDbContent.MilkProds.FirstOrDefault(p => p.id == milkId);
       
    }
}
