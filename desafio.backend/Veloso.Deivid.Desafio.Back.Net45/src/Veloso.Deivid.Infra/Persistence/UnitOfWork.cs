using Veloso.Deivid.Infra.Persistence.DataContexts;

namespace Veloso.Deivid.Infra.Persistence
{

    public sealed class UnitOfWork : IUnitOfWork
    {
        private DesafioDataContext _context;


        public UnitOfWork(DesafioDataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }

}
