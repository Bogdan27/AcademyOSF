using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentC.Core.Models;


namespace RentC.Core
{
    public class Reservation : BaseEntity
    {
        [StringLength(10)]
        [DisplayName("Cart Plate")]
        [Required]
        public string Plate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Location { get; set; }
    }
}
