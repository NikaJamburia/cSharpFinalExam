using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    public class Hotel : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public HotelOwner Owner { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        public int Rating { get; set; }
    }
}