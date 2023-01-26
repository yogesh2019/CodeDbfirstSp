using CodeDbfirstSp.Cores.Repositories;
using CodeDbfirstSp.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDbfirstSp.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoDbContext _context;

        public UnitOfWork(PlutoDbContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            // it uses same context to initialize both repositories
        }
        public ICourseRepository Courses { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
      
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
