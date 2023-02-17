using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using MyPharmacy.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MyPharmacy.Models
{
    public class Buy
    {
        [Key]
        public int Id { get; set; }

        public int MedicineId { get; set; }
        [ForeignKey(nameof(MedicineId))]
        [ValidateNever]
        public Medicine Medicine { get; set; }

        [Display(Name = "Client")]
        [Required(ErrorMessage = "Client is required")]
        public int ClientId { get; set; }
        [ForeignKey(nameof(ClientId))]
        [ValidateNever]
        public Client Client { get; set; }

        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Quantity is required")]
        public int Quantity { get; set; }

        [Display(Name = "Item Price")]
        [Required(ErrorMessage = "Item Price is required")]
        public double Price { get; set; }

        [Display(Name = "User Id")]
        public string UserId { get; set; }

        [Display(Name = "Status")]
        public BuyStatus Status { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }



    }
}
