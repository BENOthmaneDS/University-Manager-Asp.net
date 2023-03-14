using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationAuth.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string Code { get; set; }
        public string Name { get; set; }

        public string Nickname { get; set; }

        public string Email { get; set; }

        public double PhoneNumber { get; set; }
    }
}