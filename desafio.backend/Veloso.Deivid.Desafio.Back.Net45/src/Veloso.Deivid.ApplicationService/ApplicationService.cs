using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veloso.Deivid.Domain.SharedKernel;
using Veloso.Deivid.Domain.SharedKernel.Events;
using Veloso.Deivid.Infra.Persistence;

namespace Veloso.Deivid.ApplicationService
{
    public class ApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private IHandler<DomainNotification> _notifications;


        public ApplicationService(IUnitOfWork uof)
        {
            _unitOfWork = uof;
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();

        }

        public bool Commit()
        {
            if (_notifications.HasNotifications())
                return false;

            _unitOfWork.Commit();
            return true;
        }
    }
}
