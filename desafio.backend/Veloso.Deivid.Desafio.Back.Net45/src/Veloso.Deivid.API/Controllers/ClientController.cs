using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Veloso.Deivid.Domain.Commands;
using Veloso.Deivid.Domain.Services;

namespace Veloso.Deivid.API.Controllers
{
    public class ClientController : BaseController
    {
        private readonly IClientApplicationService _service;
        public ClientController(IClientApplicationService service)
        {
            this._service = service;
        }

        [HttpGet]
        [Route("api/client")]
        public Task<HttpResponseMessage> Get()
        {
            var clients = _service.Get();
            return CreateResponse(HttpStatusCode.Created, clients);
        }

        [HttpGet]
        [Route("api/client/{socialCode}")]
        public Task<HttpResponseMessage> Get(string socialCode)
        {
            var client = _service.Get(socialCode);
            return CreateResponse(HttpStatusCode.Created, client);
        }

        [HttpPost]
        [Route("api/client")]
        public Task<HttpResponseMessage> Post([FromBody]CreateClientCommand command)
        {
            var client = _service.Create(command);
            return CreateResponse(HttpStatusCode.Created, client);
        }

        [HttpPut]
        [Route("api/client/{id}")]
        public Task<HttpResponseMessage> Put(int id, [FromBody]UpdateClientCommand command)
        {
            var client = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, client);
        }

        [HttpDelete]
        [Route("api/client/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            var command = new DeleteClientCommand(id);
            var client = _service.Delete(command);
            return CreateResponse(HttpStatusCode.OK, client);
        }
    }
}