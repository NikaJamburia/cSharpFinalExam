using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    [Component]
    public class Hotel : BaseEntity
    {
        public string Name { get; set; }
        public HotelOwner Owner { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Rating { get; set; }
    }
}