using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Veloso.Deivid.Domain.Entities;
using Veloso.Deivid.Domain.Scopes;

namespace Veloso.Deivid.Domain.Tests.Scopes
{
    [TestClass]
    public class ClientScopeTests
    {
        [TestMethod]
        [TestCategory("Client")]
        public void ShouldRegisterClient()
        {
            var client = new Client("38749957805", "Deivid Veloso", "veloso.deivid@gmail.com", "11952379203", false,null, null);
            Assert.AreEqual(true, ClientScopes.CreateClientScopeIsValid(client));
        }

        [TestMethod]
        [TestCategory("Client")]
        public void ShouldNotRegisterClient()
        {
            var client = new Client("", "Deivid Veloso", "veloso.deivid@gmail.com", "11952379203", false, null, null);
            Assert.AreEqual(false, ClientScopes.CreateClientScopeIsValid(client));
        }

        [TestMethod]
        [TestCategory("Client")]
        public void ShouldValidNameLenghtClient()
        {
            var client = new Client("38749957805", "Deivid Veloso dddddddddddddddddddddddddddddddddasdfasdfasdfsafasdfasfasfdasdfafasfasdfasdfasfasdfsfdasfasdfdasfasfd", "veloso.deivid@gmail.com", "11952379203", false, null, null);
            Assert.AreEqual(false, ClientScopes.CreateClientScopeIsValid(client));
        }
    }
}
