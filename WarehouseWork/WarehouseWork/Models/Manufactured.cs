using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WarehouseWork.Models
{
    public class Manufactured
    {
        public int id { get; set; }
        [Required]
        [DisplayName("Manufactured Name")]
        public string name { get; set; }
        public int countryid { get; set; }
        public Country country { get; set; }
    }
}
