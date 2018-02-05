using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veloso.Deivid.Domain.Commands
{
    public class GetClientCommand
    {
        public string SocialCode { get;  set; }
        public GetClientCommand(string socialCode)
        {
            SocialCode = socialCode;
        }
    }
}
