using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WarehouseWork.Models
{
    public class Product
    {
        public int id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string name { get; set; }

        public int manufacturedid { get; set; }

        public Manufactured manufactured { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}")]
        public DateTime registrationDate { get; set; }

        [Required]
        [DisplayName("Category")]
        public string category { get; set; }

        [Required]
        [Range(0.1, (7.9 * 1028))]
        [DisplayName("Price")]
        public decimal price { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        [DisplayName("Count")]
        public int count { get; set; }

        [Required]
        [DisplayName("Discount Percentage")]
        [Range(0.1, 99.9)]
        public float discountPercentage { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}")]
        [DisplayName(" First Discount Day")]
        public DateTime? StartDiscountsDependingSeasonDay { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMMM yyyy}")]
        [DisplayName("Last Discount Day")]
        public DateTime? LastDiscountsDependingSeasonDay { get; set; }
    }
}
