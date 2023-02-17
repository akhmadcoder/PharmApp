using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyPharmacy.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Medicine name")]
        [Required(ErrorMessage = "Medicine Name is required")]
        public string Name { get; set; }

        [Display(Name = "Category")]
        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        [ValidateNever]
        public Category Category { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        public int CountryId { get; set; }
        [ForeignKey(nameof(CountryId))]
        [ValidateNever]
        public Country Country { get; set; }

        [Display(Name = "Code")]
        public string Code { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Manufacture Date")]
        [Required(ErrorMessage = "Manufacture Date is required")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ManufactureDate { get; set; }

        [Display(Name = "Expire Date")]
        [Required(ErrorMessage = "Expire Date is required")]
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExpireDate { get; set; }

        
        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }
    }
}
