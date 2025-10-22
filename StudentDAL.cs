using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OkulSis
{
    public class StudentDAL
    {
        public List<Student> GetAll() {
            using (OkulSisContext context = new OkulSisContext())
            {
                return context.Students.ToList();
            }
        }
        public void Add(Student student)
        {
            using (OkulSisContext context = new OkulSisContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public List<Student> GetStudent(string studentName)
        {
            using(OkulSisContext context = new OkulSisContext())
            {
                return context.Students.Where(s => s.StudentName == studentName).ToList();
            }
        }
        public List<Student> GetStudent(int studentNumber)
        {
            using (OkulSisContext context = new OkulSisContext())
            {
                return context.Students.Where(s => s.StudentNumber == studentNumber).ToList();
            }
        }
        public List<Student> GetStudent(string studentName, int studentNumber)
        {
            using (OkulSisContext context = new OkulSisContext())
            {
                return context.Students.Where(s => s.StudentNumber == studentNumber || s.StudentName == studentName).ToList();
            }
        }
    }
}
