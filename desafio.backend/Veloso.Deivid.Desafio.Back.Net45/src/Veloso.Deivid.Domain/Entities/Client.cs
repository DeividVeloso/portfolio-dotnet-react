using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veloso.Deivid.Domain.Scopes;

namespace Veloso.Deivid.Domain.Entities
{
    public class Client
    {
        protected Client()
        {

        }
        public Client(string socialCode, string fullName, string email, string telephone, bool disabled, DateTime? dtCriated, DateTime? dtUpdated)
        {
            SocialCode = socialCode;
            FullName = fullName;
            Email = email;
            Telephone = telephone;
            Disabled = disabled;
            DtCriated = dtCriated;
            DtUpdated = dtUpdated;
        }

        public int Id { get;  set; }
        public string SocialCode { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Telephone { get; private set; }
        public bool Disabled { get; private set; }
        public DateTime? DtCriated { get; set; }
        public DateTime? DtUpdated { get; set; }

        public void Register()
        {
            this.CreateClientScopeIsValid();
        }
    }
}
