using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veloso.Deivid.Domain.Entities;
using Veloso.Deivid.Domain.SharedKernel.Validation;

namespace Veloso.Deivid.Domain.Scopes
{
    public static class ClientScopes
    {
        public static bool CreateClientScopeIsValid(this Client client)
        {
            return AssertionConcern.IsSatisfiedBy
                (
                    AssertionConcern.AssertNotEmpty(client.SocialCode, "O CPF precisa ser preenchido."),
                    AssertionConcern.AssertNotEmpty(client.FullName, "O Nome Completo precisa ser preenchido."),
                    AssertionConcern.AssertNotEmpty(client.Email, "O E-mail precisa ser preenchido."),
                    AssertionConcern.AssertNotEmpty(client.Telephone, "O Telefone precisa ser preenchido."),

                    AssertionConcern.AssertLength(client.SocialCode, 11, 13, "CPF inválido, deve ser entre 11 e 13 caracteres"),
                    AssertionConcern.AssertLength(client.FullName, 9, 100, "Nome Completo inválido, deve ser entre 9 e 100 caracteres"),
                    AssertionConcern.AssertLength(client.Telephone, 9, 11, "Telephone inválido, deve ser entre 9 e 11 caracteres"),
                    AssertionConcern.AssertLength(client.Email, 5, 200, "Email inválido, deve ser entre 5 e 200 caracteres"),
                    AssertionConcern.AssertMatches(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$", client.Email, "Informe um e-mail válido")

                );
        }
    }
}
