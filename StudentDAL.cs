using System;
using System.Collections.Generic;
using System.Linq;
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
            
    }
}
