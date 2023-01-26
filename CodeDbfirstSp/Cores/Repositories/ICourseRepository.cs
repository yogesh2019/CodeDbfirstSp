using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDbfirstSp.Cores.Repositories
{
    public interface ICourseRepository : IRepository<Cours>
    {
        IEnumerable<Cours> GetTopSellingCourses(int count);
        IEnumerable<Cours> GetCoursesWithAuthors(int pageIndex, int pageSize);
    }
}
