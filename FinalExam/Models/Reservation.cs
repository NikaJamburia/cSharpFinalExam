using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    public class Reservation : BaseEntity
    {
        [Required]
        public User User { get; set; }
        [Required]
        public Room Room { get; set; }
        [Required]
        public DateTime CheckIn { get; set; }
        [Required]
        public DateTime CheckOut { get; set; }
    
    }
}