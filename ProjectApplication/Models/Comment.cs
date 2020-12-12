using ProjectApplication.Data.Models;

namespace ProjectApplication.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string message { get; set; }
        public string owner { get; set; }
        public MilkProd MilkProd { get; set; }
        public int MilkProdId { get; set; }
    }
}