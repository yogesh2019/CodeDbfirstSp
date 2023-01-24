using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDbfirstSp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoDbContext();

            var course = context.Courses.Find(16);

            course.Title = "modified course";
            context.SaveChanges();

        }
    }
}
