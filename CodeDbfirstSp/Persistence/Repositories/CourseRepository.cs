using CodeDbfirstSp.Cores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeDbfirstSp.Persistence.Repositories
{
    public class CourseRepository : Repository<Cours>, ICourseRepository
    {
        public CourseRepository(PlutoDbContext context)
            :base(context)
        {

        }

        

        public IEnumerable<Cours> GetTopSellingCourses(int count)
        {
            throw new NotImplementedException();
        }
        
        public IEnumerable<Cours> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        { 
            return PlutoDbContext.Courses
                .Include(c => c.Author)
                .OrderBy(c => c.Title)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public PlutoDbContext PlutoDbContext
        {
            get { return Context as PlutoDbContext; }
        }
    }
}
