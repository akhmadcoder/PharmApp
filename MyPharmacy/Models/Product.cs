using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace MyPharmacy.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public int Quantity { get; set; }
        public double Price { get; set; }

        public int BuyId { get; set; }
        [ForeignKey(nameof(BuyId))]
        [ValidateNever]
        public Buy Buy { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime), DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Updated { get; set; }

    }
}
