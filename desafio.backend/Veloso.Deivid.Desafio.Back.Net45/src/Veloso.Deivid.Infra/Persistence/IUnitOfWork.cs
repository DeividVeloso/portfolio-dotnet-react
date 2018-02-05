using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veloso.Deivid.Infra.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
