using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veloso.Deivid.Domain.Entities;

namespace Veloso.Deivid.Domain.Repositories
{
    public interface IClientRepository
    {
        List<Client> Get();
        List<Client> Get(int skip, int take);
        Client Get(int id);
        Client Get(string socialCode);
        void Create(Client client);
        void Update(Client client);
        void Delete(Client client);
    }
}
