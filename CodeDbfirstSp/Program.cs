using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDbfirstSp
{
    class Program
    {
        static void Main(string[] args)
        {
            var _context = new PlutoDbContext();
            var query =
               _context.Courses.Where(c => c.CourseID == 1);

            foreach (var i in query)
            {
                Console.WriteLine(i.Title);
            }
            Console.ReadLine();
        }
    }
}
