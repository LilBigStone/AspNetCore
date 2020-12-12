using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApplication.Data.Models
{
    public class MilkProd
    {
        public int id { get; set; }
        public string name { get; set; }
        public string temperature { get; set; }
        public string storageDate { get; set; }
        public string mass { get; set; }
        public string img { get; set; }
        public string fatMass { get; set; }
        public ushort price { get; set; }
        public bool isFavourite { get; set; }
        public bool available { get; set; }
        public int categoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
