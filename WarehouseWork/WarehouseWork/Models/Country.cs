using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseWork.Models
{
    public class Country
    {
        public int id { get; set; }
        [Required]
        [DisplayName("Country Name")]
        public string name { get; set; }
    }
}
