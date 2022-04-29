using System.ComponentModel.DataAnnotations;

namespace MainService.Models
{
    public class Items
    {
        [Key]
        public int id { get; set; }

        public string itemName { get; set; }
        public int qty { get; set; }
        public decimal price { get; set; }



    }
}
