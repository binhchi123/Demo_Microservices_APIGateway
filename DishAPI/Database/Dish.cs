using System.ComponentModel.DataAnnotations;

namespace DishAPI.Database
{
    public class Dish
    {
        [Key]
        public int    MonAnId { get; set; }
        public string TenMon  { get; set; }
        public string GhiChu  { get; set; }
    }
}
