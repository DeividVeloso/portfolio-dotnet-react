using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veloso.Deivid.Domain.Entities;
using Veloso.Deivid.Domain.Repositories;
using Veloso.Deivid.Domain.Specs;
using Veloso.Deivid.Infra.Persistence.DataContexts;

namespace Veloso.Deivid.Infra.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly DesafioDataContext _context;
        public ClientRepository(DesafioDataContext contex)
        {
            this._context = contex;
        }

        public void Create(Client client)
        {
            _context.Clients.Add(client);
        }

        public void Delete(Client client)
        {
            _context.Clients.Remove(client);
        }

        public List<Client> Get()
        {
            return _context.Clients.Where(ClientSpec.GetClientsActive()).ToList();

        }

        public List<Client> Get(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public Client Get(int id)
        {
            return _context.Clients
                                 //.AsNoTracking()
                                 .Where(x => x.Id == id && x.Disabled == false)
                                 .FirstOrDefault();
        }

        public Client Get(string socialCode)
        {
            return _context.Clients
                                 //.AsNoTracking()
                                 .Where(ClientSpec.GetClientBySocialCode(socialCode))
                                 .FirstOrDefault();
        }

        public void Update(Client client)
        {
            _context.Entry<Client>(client).State = EntityState.Modified;
        }
    }
}
