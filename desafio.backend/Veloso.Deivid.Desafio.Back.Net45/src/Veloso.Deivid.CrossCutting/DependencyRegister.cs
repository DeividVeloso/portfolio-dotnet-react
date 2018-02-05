using Unity;
using Unity.Lifetime;
using Veloso.Deivid.ApplicationService;
using Veloso.Deivid.Domain.Repositories;
using Veloso.Deivid.Domain.Services;
using Veloso.Deivid.Domain.SharedKernel;
using Veloso.Deivid.Domain.SharedKernel.Events;
using Veloso.Deivid.Infra.Persistence;
using Veloso.Deivid.Infra.Persistence.DataContexts;
using Veloso.Deivid.Infra.Repositories;

namespace Veloso.Deivid.CrossCutting
{
    public static class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<DesafioDataContext, DesafioDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IClientRepository, ClientRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IClientApplicationService, ClientApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());

        }
    }
}
