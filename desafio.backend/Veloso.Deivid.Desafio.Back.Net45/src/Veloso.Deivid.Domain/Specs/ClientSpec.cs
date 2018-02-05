using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Veloso.Deivid.Domain.Entities;

namespace Veloso.Deivid.Domain.Specs
{
    public static class ClientSpec
    {
        public static Expression<Func<Client, bool>> GetClientBySocialCode(string socialCode)
        {
            return x => x.SocialCode == socialCode && x.Disabled == false;
        }

        public static Expression<Func<Client, bool>> GetClientsActive()
        {
            return x => x.Disabled == false;
        }
    }
}
