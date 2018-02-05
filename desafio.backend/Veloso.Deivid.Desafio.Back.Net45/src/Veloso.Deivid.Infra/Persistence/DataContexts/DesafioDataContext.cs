using System.Data.Entity;
using Veloso.Deivid.Domain.Entities;
using Veloso.Deivid.Infra.Persistence.Map;

namespace Veloso.Deivid.Infra.Persistence.DataContexts
{
    public class DesafioDataContext : DbContext
    {
        public DesafioDataContext()
            : base("DesafioConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ClientMap());
        }
    }
}
;