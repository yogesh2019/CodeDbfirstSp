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
               .GroupBy(c => c.Level);

            foreach (var i in query)
            {
                Console.WriteLine("group key:",i.Key);
                foreach(var t in i)
                {
                    Console.WriteLine("\t{0}",t.Description);
                }
            }
            Console.ReadLine();
        }
    }
}
