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
                from a in _context.Authors
                join c in _context.Courses on a.AuthorID equals c.AuthorID into g
                select new { AuthorName = a.Name, Courses = g.Count() };
            foreach (var i in query)
                Console.WriteLine("{0}({1})",i.AuthorName,i.Courses);
            Console.ReadLine();
        }
    }
}
