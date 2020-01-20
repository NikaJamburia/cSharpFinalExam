using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    [Component]
    public class Reservation : BaseEntity
    {
        public User User { get; set; }
        public Room Room { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
    
    }
}