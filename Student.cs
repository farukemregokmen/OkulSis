using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OkulSis
{
    internal class Student
    {
        [Key]
        public int StudentNumber { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudentClass { get; set; }
    }
}
