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
               .Where(c => c.Level == 0).
               Select(c => c.Author);

            foreach (var i in query)
            {
                foreach(var a in i) 
                    {

                    } 
            }
            Console.ReadLine();
        }
    }
}
