using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalExam.Models;

namespace FinalExam.Dto
{
    public class HotelDto
    {
        public long Id { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string Name { get; set; }
        public int OwnerId { get; set; }
        public string OwnerName { get; set; }
        public string OwnerTelNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Rating { get; set; }

    }
}