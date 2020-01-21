using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    public class Room : BaseEntity
    {
        [Required]
        public int Number { get; set; }
        [Required]
        public Hotel hotel { get; set; }
        [Required]
        public int NumberOfBeds { get; set; }
        [Required]
        public int PricePerNight { get; set; }
    }
}