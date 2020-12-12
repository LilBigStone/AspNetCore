using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectApplication.Data.Interfaces;
using ProjectApplication.Data.Models;

namespace ProjectApplication.Data.mocks
{
    public class MockMilks : IAllMilks
    {

        private readonly IMilkCategory _beerCategory = new MockCategory();

        public IEnumerable<MilkProd> Milks {
            get
            {
                return new List<MilkProd> {
                 //   new MilkProd {name="Tesela", shortDesc = "", longDesc="",img="~/img/7kt5l8GeSfk.jpg",price=45000,isFavourite=true,available=true, Category = _beerCategory.AllCategories.First() }
                };
            }
        }
        public IEnumerable<MilkProd> getFavMilks { get; set; }

        public MilkProd getObjectMilk(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
