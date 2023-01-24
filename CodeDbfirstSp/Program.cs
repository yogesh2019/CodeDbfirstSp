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
            var context = new PlutoDbContext();
            var query =
                from c in context.Courses
                where c.Title.Contains("C#")
                orderby c.Title
                select c;
                
            foreach (var course in query)
                Console.WriteLine(course.Title);



            var courseExt = context.Courses.Where(c => c.Title.Contains("c#")).ToList();
            /*foreach( var c in courseExt)
                Console.WriteLine(c.Title);*//*foreach( var c in courseExt)
                Console.WriteLine(c.Title);*/
            Console.ReadLine();
        }
    }
}
