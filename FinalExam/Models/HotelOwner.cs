using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    public class HotelOwner : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string TelNumber { get; set; }
        [Required]
        public string Email { get; set; }

    }
}