using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    [Component]
    public class HotelOwner : BaseEntity
    {
        public string Name { get; set; }
        public string TelNumber { get; set; }
        public string Email { get; set; }

    }
}