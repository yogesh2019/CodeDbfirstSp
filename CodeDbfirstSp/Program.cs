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

            var course = new Cours
            {
                Title = "New course",
                Description = "new description",
                Price = 19,
                Level = 1,
                Author = new Author { AuthorID = 1, Name = "new author" }
            };
            context.Courses.Add(course);
            context.SaveChanges();
        }
    }
}
