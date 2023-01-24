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
                join a in _context.Authors on c.AuthorID equals a.AuthorID
                where c.Title.Contains("c#")
                select new { CourseName = c.Title, AuthorName = a.Name};
            
            foreach(var item in query)
            {
                Console.WriteLine("{0}",item.CourseName);
            }
            Console.ReadLine();
        }
    }
}
