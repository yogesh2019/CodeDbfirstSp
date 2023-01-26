using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeDbfirstSp.Cores.Repositories
{
    interface IUnitOfWork : IDisposable
    {
        ICourseRepository Course { get; }
        int Complete();
    }
}
