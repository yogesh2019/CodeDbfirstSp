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
               _context.Courses.Where(c => c.Level == 0).OrderBy(c => c.Level).ThenByDescending(c => c.Title);

            foreach (var i in query)
            {
                Console.WriteLine(i.Title);
            }
            Console.ReadLine();
        }
    }
}
