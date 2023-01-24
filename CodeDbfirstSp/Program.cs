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
               _context.Courses
               .Join(_context.Authors,
               c => c.AuthorID,
               a => a.AuthorID,
               (course, author) => new { Name= course.Title, });

            foreach(var i in query)
            {
                Console.WriteLine(i.Name);
            }
            Console.ReadLine();
        }
    }
}
