using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalExam.Models
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
    }
}