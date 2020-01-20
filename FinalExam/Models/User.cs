using Spring.Stereotype;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    public class User : BaseEntity
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }

    }
}