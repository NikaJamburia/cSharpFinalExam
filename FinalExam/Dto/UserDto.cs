using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExam.Dto
{
    public class UserDto
    {
        public long Id { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}