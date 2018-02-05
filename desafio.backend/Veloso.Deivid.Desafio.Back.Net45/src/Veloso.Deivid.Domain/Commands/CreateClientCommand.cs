using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veloso.Deivid.Domain.Commands
{
    public class CreateClientCommand
    {
        public string SocialCode { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public DateTime DtCriated { get; set; }

        public CreateClientCommand(string socialCode, string fullName, string email, string telephone)
        {
            SocialCode = socialCode;
            FullName = fullName;
            Email = email;
            Telephone = telephone;
            DtCriated = DateTime.Now;
        }
    }
}
