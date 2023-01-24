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
            var query = from c in _context.Courses
                        where c.Title.Contains("C#")
                        orderby c.Title descending
                        select c;
            foreach( var c in query)
                Console.WriteLine(c.Title );
            Console.ReadLine();
        }
    }
}
