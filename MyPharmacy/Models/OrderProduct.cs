using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MyPharmacy.Models
{
    public class OrderProduct
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Product name")]
        [Required(ErrorMessage = "Product name is required")]
        public string Name { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [ValidateNever]
        public Category Category { get; set; }

        [Display(Name = "Description")]
        [ValidateNever]
        public string Description { get; set; }
    }
}
