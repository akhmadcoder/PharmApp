using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MyPharmacy.Models
{
    public class Sell
    {
        [Key]
        public int Id { get; set; }

        public int MedicineId { get; set; }
        [ForeignKey(nameof(MedicineId))]
        [ValidateNever]
        public Medicine Medicine { get; set; }

        public int InvoiceId { get; set; }
        [ForeignKey(nameof(InvoiceId))]
        [ValidateNever]
        public Invoice Invoice { get; set; }

        [Display(Name = "User Id")]
        public string UserId { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        [Display(Name = "Item Price")]
        [Required(ErrorMessage = "Item Price is required")]
        public double Price { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }

    }
}
