using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veloso.Deivid.Domain.Commands;
using Veloso.Deivid.Domain.Entities;

namespace Veloso.Deivid.Domain.Services
{
    public interface IClientApplicationService
    {
        List<Client> Get();
        List<Client> Get(int skip, int take);
        Client Get(string socialCode);
        Client Create(CreateClientCommand command);
        Client Update(UpdateClientCommand command);
        Client Delete(DeleteClientCommand command);
    }
}
