using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    public class Room : BaseEntity
    {
        public int Number { get; set; }
        public Hotel hotel { get; set; }
        public int NumberOfBeds { get; set; }
        public int PricePerNight { get; set; }
    }
}