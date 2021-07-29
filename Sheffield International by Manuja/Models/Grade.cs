using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sheffield_International_by_Manuja.Models
{
    public class Grade
    {
        public int id;
        public  int StudentId { get; set; }
        public int SubjectId { get; set; }
        public double marks { get; set; }
        public string Grad { get; set; }
    }
}
