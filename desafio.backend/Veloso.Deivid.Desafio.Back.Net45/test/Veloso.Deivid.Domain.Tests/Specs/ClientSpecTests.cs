using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Veloso.Deivid.Domain.Entities;
using System.Collections.Generic;
using Veloso.Deivid.Domain.Specs;
using System.Linq;

namespace Veloso.Deivid.Domain.Tests.Specs
{
    [TestClass]
    public class ClientSpecTests
    {
        private List<Client> _clients;

        public ClientSpecTests()
        {
            this._clients = new List<Client>();
            _clients.Add(new Client("38749957805", "Deivid Veloso", "veloso.deivid@gmail.com", "11952379203", false, null, null));
            _clients.Add(new Client("57174775039", "Jose Carlos Veloso", "jose.veloso@gmail.com", "11952379203", false, null, null));
            _clients.Add(new Client("21035424282", "Ana Paula Veloso", "ana.veloso@gmail.com", "11952379203", true, null, null));
            _clients.Add(new Client("83707488306", "Lilian Veloso", "lilian.veloso@gmail.com", "11952379203", false, null, null));
        }

        [TestMethod]
        [TestCategory("Client Specs")]
        public void ShouldReturnOnlyActiveClients()
        {
            var exp = ClientSpec.GetClientsActive();
            var clients = _clients.AsQueryable().Where(exp).ToList();

            Assert.AreEqual(3, clients.Count);
        }

        [TestMethod]
        [TestCategory("Client Specs")]
        public void ShouldReturnOnlyOneClient()
        {
            var exp = ClientSpec.GetClientBySocialCode("38749957805");
            var client = _clients.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, client);
        }
    }
}
