using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationAuth.Models
{
    public class Professor
    {
        public int ID { get; set; }
        public string ProfessorName { get; set; }
        public string ProfessorLastname { get; set; }
        public string Profession { get; set; }
        
        public virtual Account Account { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}