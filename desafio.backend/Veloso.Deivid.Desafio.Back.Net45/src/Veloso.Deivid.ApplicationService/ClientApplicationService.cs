using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veloso.Deivid.Domain.Commands;
using Veloso.Deivid.Domain.Entities;
using Veloso.Deivid.Domain.Repositories;
using Veloso.Deivid.Domain.Services;
using Veloso.Deivid.Domain.SharedKernel;
using Veloso.Deivid.Domain.SharedKernel.Events;
using Veloso.Deivid.Infra.Persistence;

namespace Veloso.Deivid.ApplicationService
{
    public class ClientApplicationService : ApplicationService, IClientApplicationService
    {
        private readonly IClientRepository _repository;
        public ClientApplicationService(IClientRepository repository, IUnitOfWork uof) : base(uof)
        {
            _repository = repository;
        }

        public Client Create(CreateClientCommand command)
        {
            var client = new Client(command.SocialCode, command.FullName, command.Email, command.Telephone, false, DateTime.Now, null);
            client.Register();

            _repository.Create(client);

            if (Commit())
                return client;

            return null;
        }

        public Client Update(UpdateClientCommand command)
        {
            //var clientDb = _repository.Get(command.Id);
            //if (clientDb != null)
            //{
            var client = new Client(command.SocialCode, command.FullName, command.Email, command.Telephone, false, DateTime.Now, DateTime.Now);
            client.Id = command.Id;
            client.Register();
            _repository.Update(client);

            if (Commit())
                return client;
            //}
            return null;
        }

        public Client Delete(DeleteClientCommand command)
        {
            var clientDb = _repository.Get(command.Id);
            if (clientDb != null)
            {
                _repository.Delete(clientDb);

                if (Commit())
                    return clientDb;
            }
            return null;
        }

        public List<Client> Get()
        {
            return _repository.Get();
        }

        public List<Client> Get(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Client Get(string socialCode)
        {
            return _repository.Get(socialCode);
        }
    }
}
