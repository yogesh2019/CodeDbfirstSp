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
                from c in _context.Courses
                from a in _context.Authors
                select new { AuthorName = a.Name, CourseName = c.Title };

            foreach (var i in query)
            {
                Console.WriteLine("{0},{1}",i.AuthorName,i.CourseName);
            }
            Console.ReadLine();
        }
    }
}
