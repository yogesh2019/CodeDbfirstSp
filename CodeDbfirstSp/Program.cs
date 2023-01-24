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
                group c by c.Level into g
                select g;
            
            foreach(var group in query)
            {
                Console.WriteLine(group.Key);
                foreach(var item in group)
                    Console.WriteLine("\t {0}",item.Title);
            }
            Console.ReadLine();
        }
    }
}
