using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ProjectApplication.Data.Interfaces;
using System.Threading.Tasks;
using ProjectApplication.Data;
using ProjectApplication.ViewModels;
using ProjectApplication.Data.Models;

namespace ProjectApplication.Controllers
{
    public class MilkController: Controller
    {
        private readonly IAllMilks _allMilks;
        private readonly IMilkCategory _allCategories;
        private appDBcontent db;
        
        public MilkController(IAllMilks iallMilks, IMilkCategory imilkCategory, appDBcontent context)
        {
            db = context;
            _allMilks = iallMilks;
            _allCategories = imilkCategory;
        }

        [Route("Milk/List")]
        [Route("Milk/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<MilkProd> milks = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                milks = _allMilks.Milks.OrderBy(i => i.id);
            }
            else
            {
                if(string.Equals("cheese", category, StringComparison.OrdinalIgnoreCase))
                {
                    milks = _allMilks.Milks.Where(i => i.Category.categoryName.Equals("Сыры")).OrderBy(i => i.id);
                    currCategory = "Сыры";
                }else if(string.Equals("milk", category, StringComparison.OrdinalIgnoreCase))
                {
                    milks = _allMilks.Milks.Where(i => i.Category.categoryName.Equals("Цельномолочная продукция")).OrderBy(i => i.id);
                    currCategory = "Цельномолочная продукция";
                }
                else if (string.Equals("kidsMilk", category, StringComparison.OrdinalIgnoreCase))
                {
                    milks = _allMilks.Milks.Where(i => i.Category.categoryName.Equals("Молочные продукты для детей")).OrderBy(i => i.id);
                    currCategory = "Молочные продукты для детей";
                }
                else if (string.Equals("butter", category, StringComparison.OrdinalIgnoreCase))
                {
                    milks = _allMilks.Milks.Where(i => i.Category.categoryName.Equals("Масло")).OrderBy(i => i.id);
                    currCategory = "Масло";
                }
                else if (string.Equals("sgush", category, StringComparison.OrdinalIgnoreCase))
                {
                    milks = _allMilks.Milks.Where(i => i.Category.categoryName.Equals("Молочные консервы")).OrderBy(i => i.id);
                    currCategory = "Молочные консервы";
                }



            }
            var milkObj = new MilksListViewModel
            {
                allMilks = milks,
                currCategory = currCategory,
            };

            return View(milkObj);
        }

        public ViewResult DetailPage(int id)
        {
            var item = _allMilks.Milks.FirstOrDefault(i => i.id == id);
            
            ViewBag.Milk = item.name;
            ViewBag.MilkId = item.id;
            ViewBag.img = item.img;
            ViewBag.fatMass = item.fatMass;
            ViewBag.temperature = item.temperature;
            ViewBag.price = item.price;
            ViewBag.mass = item.mass;
            ViewBag.storageDate = item.storageDate;
            
            
            return View(db.Comments.Where(c => c.MilkProdId == id));
            
            
        }

    }
}
