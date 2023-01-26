using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CodeDbfirstSp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoDbContext();
           
            var query = context.Authors.GroupJoin(context.Courses, a => a.AuthorID, c => c.AuthorID, (author, courses) => new { AuthorName = author.Name, courses = courses});

            foreach(var items in query)
            {
                
               foreach(var i in items.courses)
                {
                   // Console.WriteLine(i.Title);
                }
            }
            var authors = context.spGetAuthors();
            foreach( var a in authors)
                Console.WriteLine(a.Name);
            Console.ReadLine();

        }
    }
}
