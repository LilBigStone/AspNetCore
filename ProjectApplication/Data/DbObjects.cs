using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ProjectApplication.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApplication.Data
{
    public class DbObjects
    {
        public static void Initial(appDBcontent content)
        {


            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.MilkProds.Any())
            {
                content.AddRange(
                    new MilkProd
                    {
                        name = "Сыр 'Белая Русь'",
                        mass = "8 кг.",
                        fatMass = "45%",
                        temperature = "от 0 до +4 °С",
                        storageDate = "150 суток",
                        img = "/img/belaya1.jpg",
                        price = 23,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Сыры"]
                    },

                    new MilkProd
                    {
                        name = "Сыр Грювер особый",
                        mass = "8 кг.",
                        fatMass = "45%",
                        temperature = "от 0 до +4 °С",
                        storageDate = "150 суток",
                        img = "/img/gruver.jpg",
                        price = 23,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Сыры"]
                    },

                    new MilkProd
                    {
                        name = "Сыр Голландский",
                        mass = "4 кг.",
                        fatMass = "35%,45%",
                        temperature = "от 0 до +4 °С",
                        storageDate = "150 суток",
                        img = "/img/goland.jpg",
                        price = 23,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Сыры"]
                    },

                    new MilkProd
                    {
                        name = "Сыр фасованный «Раубичский»",
                        mass = "200 г.",
                        fatMass = "35%",
                        temperature = "от +2 до +6 °С",
                        storageDate = "150 суток",
                        img = "/img/raub.jpg",
                        price = 4,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Сыры"]
                    },

                    new MilkProd
                    {
                        name = "Молоко цельное сгущенное с сахаром",
                        mass = "380г, 280г, 300г.",
                        fatMass = "8,5%",
                        temperature = "от 0 до +22 °С",
                        storageDate = "18 мес., 12 мес., 2 мес.",
                        img = "/img/groupcond3.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко частично обезжиренное сгущенное с сахаром и какао",
                        mass = "380г, 300г.",
                        fatMass = "7,5%",
                        temperature = "от 0 до +10 °С",
                        storageDate = "12 мес.",
                        img = "/img/kakao1910227.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко частично обезжиренное сгущенное с сахаром и цикорием",
                        mass = "380г, 300г.",
                        fatMass = "7%",
                        temperature = "от 0 до +22 °С",
                        storageDate = "12 мес.",
                        img = "/img/cikoriy1910229.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Cливки сгущенные с сахаром",
                        mass = "360г.",
                        fatMass = "19%",
                        temperature = "от 0 до +10 °С",
                        storageDate = "12 мес.",
                        img = "/img/slivki1910226.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко частично обезжиренное сгущенное с сахаром и натуральным кофе",
                        mass = "300г, 380г.",
                        fatMass = "7%",
                        temperature = "от 0 до +10 °С",
                        storageDate = "10 мес., 6 мес.",
                        img = "/img/kofe1910222.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко цельное сгущенное вареное с сахаром Егорка",
                        mass = "360г.",
                        fatMass = "8,5%",
                        temperature = "от 0 до +10 °С",
                        storageDate = "8 месяцев",
                        img = "/img/egorka85.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко частично обезжиренное сгущенное с сахаром",
                        mass = "380г.",
                        fatMass = "2,5%",
                        temperature = "от 0 до +22 °С",
                        storageDate = "12 месяцев",
                        img = "/img/sgush25.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко сгущенное с сахаром и ароматом Лесной орех",
                        mass = "380г.",
                        fatMass = "8,5%",
                        temperature = "от 0 до +22 °С",
                        storageDate = "12 месяцев",
                        img = "/img/oreh3.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко концентрированное стерилизованное цельное",
                        mass = "300г.",
                        fatMass = "8,6%, 7,8%",
                        temperature = "от 0 до +20 °С",
                        storageDate = "12 месяцев",
                        img = "/img/konc9.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко сгущенное с сахаром и ароматом Ваниль-сливки",
                        mass = "380г.",
                        fatMass = "8,5%",
                        temperature = "от 0 до +22 °С",
                        storageDate = "12 месяцев",
                        img = "/img/van7.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко сгущенное стерилизованное цельное",
                        mass = "300г.",
                        fatMass = "7,8%; 8,6%",
                        temperature = "от 0 до +10 °С",
                        storageDate = "12 месяцев",
                        img = "/img/ster21.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко цельное сгущенное с сахаром и ароматом Капучино",
                        mass = "380г.",
                        fatMass = "8,5%",
                        temperature = "от 0 до +22 °С",
                        storageDate = "12 месяцев",
                        img = "/img/kap34.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко цельное сгущенное с сахаром и ароматом Ирисо-сливочный",
                        mass = "380г.",
                        fatMass = "8,5%",
                        temperature = "от 0 до +22 °С",
                        storageDate = "12 месяцев",
                        img = "/img/iris6.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко частично обезжиренное сгущенное вареное с сахаром Егорка",
                        mass = "360г.",
                        fatMass = "2,5%",
                        temperature = "от 0 до +10 °С",
                        storageDate = "8 месяцев",
                        img = "/img/egorka75.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко цельное сгущенное с сахаром Халяль",
                        mass = "380г.",
                        fatMass = "8,5%",
                        temperature = "от 0 до +22 °С",
                        storageDate = "12 месяцев",
                        img = "/img/halal5.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные консервы"]
                    },
                    new MilkProd
                    {
                        name = "Молоко питьевое стерилизованное",
                        mass = "1000 мл.",
                        fatMass = "1,5%; 2,5%; 3,2%",
                        temperature = "от +4 до +25 °С",
                        storageDate = "9 месяцев",
                        img = "/img/TBA1.jpg",
                        price = 2,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Цельномолочная продукция"]
                    },

                    new MilkProd
                    {
                        name = "Молоко питьевое пастеризованное Вкусное",
                        mass = "900 мл.",
                        fatMass = "1,5%; 2,5%; 3,2%",
                        temperature = "(4±2)°С",
                        storageDate = "20 суток",
                        img = "/img/petbut9.jpg",
                        price = 2,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Цельномолочная продукция"]
                    },

                    new MilkProd
                    {
                        name = "Коктейль кисломолочный фруктовый",
                        mass = "930 мл.",
                        fatMass = "1,5%",
                        temperature = "(4±2)°С",
                        storageDate = "30 суток",
                        img = "/img/kokt7.jpg",
                        price = 2,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Цельномолочная продукция"]
                    },

                    new MilkProd
                    {
                        name = "Молоко стерилизованное для детского питания, обогащенное пребиотиком Фрутафит",
                        mass = "200 мл.",
                        fatMass = "3,2%",
                        temperature = "от 0 до +10 °С",
                        storageDate = "60 суток",
                        img = "/img/frutafit9.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные продукты для детей"]
                    },
                    new MilkProd
                    {
                        name = "Молоко питьевое стерилизованное для питания детей раннего возраста, обогащенное лактулозой",
                        mass = "200 мл.",
                        fatMass = "3,2%",
                        temperature = "от 0 до +25 °С",
                        storageDate = "4 месяца",
                        img = "/img/laktuloza3.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные продукты для детей"]
                    },
                    new MilkProd
                    {
                        name = "Молоко питьевое стерилизованное для питания детей раннего возраста",
                        mass = "200 мл.",
                        fatMass = "3,2%",
                        temperature = "от 0 до +25 °С",
                        storageDate = "4 месяца",
                        img = "/img/det_mol2.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные продукты для детей"]
                    },
                    new MilkProd
                    {
                        name = "Биокефир для питания детей раннего возраста",
                        mass = "200 мл.",
                        fatMass = "3,2%",
                        temperature = "(4±2)°С",
                        storageDate = "7 суток",
                        img = "/img/biokefir9.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные продукты для детей"]
                    },
                    new MilkProd
                    {
                        name = "Био-творог для питания детей от 6 мес. до 3 лет",
                        mass = "100 г.",
                        fatMass = "4%",
                        temperature = "(4±2)°С",
                        storageDate = "7 суток",
                        img = "/img/bio-tvorog2.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Молочные продукты для детей"]
                    },

                    new MilkProd
                    {
                        name = "Масло сладкосливочное несоленое Крестьянское",
                        mass = "180 г.",
                        fatMass = "72,5%",
                        temperature = "(3±2)°С - по ГОСТ;(4±2)°С - по СТБ; -(13-18)°С.",
                        storageDate = "60 сут.; 120 сут.",
                        img = "/img/oil725.jpg",
                        price = 1,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Масло"]
                    },
                new MilkProd
                {
                    name = "Масло сладкосливочное несоленое Традиционное",
                    mass = "180 г.",
                    fatMass = "82,5%",
                    temperature = "(3±2)°С;-(6±3)°С; -(16±2)°С.",
                    storageDate = "60 сут.; 120 сут.",
                    img = "/img/oil825.jpg",
                    price = 1,
                    isFavourite = false,
                    available = true,
                    Category = Categories["Масло"]
                },
                new MilkProd
                {
                    name = "Масло сладкосливочное несоленое весовое",
                    mass = "упаковка 20кг.",
                    fatMass = "72,5%; 82,5%",
                    temperature = "-(6±3)°С; -(16±2)°С",
                    storageDate = "9 мес.; 15 мес.",
                    img = "/img/vesovoe8.jpg",
                    price = 20,
                    isFavourite = false,
                    available = true,
                    Category = Categories["Масло"]
                },
                new MilkProd
                {
                    name = "Масло сладкосливочное несоленое",
                    mass = "180 г.",
                    fatMass = "67%",
                    temperature = "(4±2)°С; -(13-18)°С.",
                    storageDate = "60 сут.; 75 сут.",
                    img = "/img/oil67.jpg",
                    price = 1,
                    isFavourite = false,
                    available = true,
                    Category = Categories["Масло"]
                }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Сыры", desc = "Сыры" },
                        new Category { categoryName = "Цельномолочная продукция", desc = "Цельномолочная продукция" },
                        new Category { categoryName = "Молочные продукты для детей", desc = "Молочные продукты для детей" },
                        new Category { categoryName = "Масло", desc = "Масло" },
                        new Category { categoryName = "Молочные консервы", desc = "Молочные консервы" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category elements in list)
                    {
                        category.Add(elements.categoryName, elements);
                    }
                }
                return category;
            }
        }
    }
}
