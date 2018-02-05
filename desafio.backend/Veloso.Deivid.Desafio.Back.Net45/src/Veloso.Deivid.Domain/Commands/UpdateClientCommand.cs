using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veloso.Deivid.Domain.Commands
{
    public class UpdateClientCommand
    {
        public int Id { get; set; }
        public string SocialCode { get;  set; }
        public string FullName { get;  set; }
        public string Email { get;  set; }
        public string Telephone { get;  set; }
        public DateTime DtUpdate { get;  set; }

        public UpdateClientCommand(int id, string socialCode, string fullName, string email, string telephone, DateTime dtUpdate)
        {
            Id = id;
            SocialCode = socialCode;
            FullName = fullName;
            Email = email;
            Telephone = telephone;
            DtUpdate = dtUpdate;
        }
    }
}
